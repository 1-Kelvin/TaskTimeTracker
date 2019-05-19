using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Helpers;

namespace TaskTimeTracker.Entities
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Todo> Todos { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectUser> ProjectUsers { get; set; }

        public UserContext() { }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(u => u.Created)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Todo>()
            .HasOne<User>(todo => todo.User)
            .WithMany(user => user.ToDos)
            .HasForeignKey(u => u.UserID)
            .IsRequired(false);

            modelBuilder.Entity<Todo>()
                .HasOne<Project>(todo => todo.Project)
                .WithMany(project => project.Todos)
                .HasForeignKey(project => project.ProjectID)
                .IsRequired(false);

            modelBuilder.Entity<ProjectUser>()
                .HasKey(pu => new { pu.UserId, pu.ProjectId });

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.User)
                .WithMany(user => user.ProjectUsers)
                .HasForeignKey(pu => pu.UserId);

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(project => project.ProjectUsers)
                .HasForeignKey(pu => pu.ProjectId);

            DataGenerator generator = new DataGenerator(modelBuilder);
            generator.GenerateTestData();


            // this will singularize all table names
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }
        }
    }
}
