using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.DTOs
{
    public class CreateTodoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ToFinish { get; set; }
        [DefaultValue(false)] // is this ok in dto?
        public bool Finished { get; set; }
        public int? UserID { get; set; }
        public int? ProjectID { get; set; }
    }
}
