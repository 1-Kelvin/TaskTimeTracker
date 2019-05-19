using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.Entities
{
    public class User : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Firstname { get; set; }


        [Required, MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }


        public DateTime Created { get; set; }


        public bool Active { get; set; }


        public virtual ICollection<Todo> Todos { get; set; }


        [Range (1, 5)]
        public int Level { get; set; }

        public List<ProjectUser> ProjectUsers { get; set; }
    }
}
