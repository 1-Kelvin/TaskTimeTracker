using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.Entities
{
    public class ProjectUser
    {
        public int ProjectId { get; set; }
        [JsonIgnore]
        public Project Project { get; set; }

        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

    }
}
