using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.DTOs
{
    public class TodoViewDTO
    {
        public int? ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ToFinish { get; set; }
        public int? EstimatedHours { get; set; }
        public int? WorkingHours { get; set; }
        public bool Finished { get; set; }
    }
}
