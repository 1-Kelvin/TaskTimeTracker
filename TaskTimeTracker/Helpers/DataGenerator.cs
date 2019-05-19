using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTimeTracker.Entities;

namespace TaskTimeTracker.Helpers
{
    public class DataGenerator
    {
        private ModelBuilder _modelBuilder;
        private IList<User> _users;
        private IList<Project> _projects;

        public DataGenerator (ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void GenerateTestData()
        {
            GenerateUsers();
            GenerateProjects();
            GenerateTodos();
        }

        // methods

        private void GenerateUsers()
        {
            var users = Builder<User>.CreateListOfSize(20)
                .All()
                    .With(u => u.Firstname = Faker.Name.First())
                    .With(u => u.Lastname = Faker.Name.Last())
                    .With(u => u.Password = "1234")
                    .With(u => u.Email = Faker.Internet.Email())
                    .With(u => u.Active = true)
                    .With(u => u.Level = Faker.RandomNumber.Next(1, 6))
                    .With(u => u.Created = DateTime.Now)
                .Build();

            _users = users;
            _modelBuilder.Entity<User>().HasData(users);
        }

        private void GenerateProjects()
        {
            var projects = Builder<Project>.CreateListOfSize(5)
                .All()
                    .With(p => p.Name = Faker.Internet.DomainName())
                    .With(p => p.Description = Faker.Lorem.Paragraph())
                    .With(p => p.Finished = false)
                    .With(p => p.UserID = null)
                .Build();

            _projects = projects;
            _modelBuilder.Entity<Project>().HasData(projects);
        }

        private void GenerateTodos()
        {
            var todos = Builder<Todo>.CreateListOfSize(30)
                .All()
                    .With(t => t.Title = Faker.Internet.DomainWord())
                    .With(t => t.UserID = null)
                    .With(t => t.ProjectID = null)
                    .With(t => t.WorkingHours = 0)
                    .With(t => t.EstimatedHours = Faker.RandomNumber.Next(1, 20))
                    .With(t => t.Finished = false)
                    .With(t => t.ToFinish = DateTime.Now.AddDays(30))
                .Random(10)
                    .With(t => t.UserID = Pick<User>.RandomItemFrom(_users).Id)
                .Random(25)
                    .With(t => t.ProjectID = Pick<Project>.RandomItemFrom(_projects).Id)
                .Build();

            _modelBuilder.Entity<Todo>().HasData(todos);
        }

        


        // Faker.Net (1.1.1) -- generate names, other data
        // NBuilder (6.0.0) -- creates list of size
    }
}
