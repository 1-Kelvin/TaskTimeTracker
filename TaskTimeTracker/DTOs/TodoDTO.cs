using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.DTOs
{
    public class TodoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ToFinish { get; set; }
        public int? WorkingHours { get; set; }
        public int? EstimatedHours { get; set; }
        [DefaultValue(false)]
        public bool Finished { get; set; }
        public int? UserID { get; set; }
        public int? ProjectID { get; set; }
    }
}
