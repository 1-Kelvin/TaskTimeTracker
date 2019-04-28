using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.Entities
{
    public class Project : BaseEntity
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UserID { get; set; }
        public bool Finished { get; set; }
        public List<ProjectUser> ProjectUsers {get;set;}
        public List<Todo> Todos { get; set; }
    }
}
