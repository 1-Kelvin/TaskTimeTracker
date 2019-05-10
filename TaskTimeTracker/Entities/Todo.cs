using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.Entities
{
    public class Todo : BaseEntity
    {
        [Required, MaxLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ToFinish { get; set; }
        public int? WorkingHours { get; set; }
   
        [DefaultValue(false)]
        public bool Finished { get; set; }
        public int? UserID { get; set; }


        // https://github.com/aspnet/EntityFrameworkCore/issues/14147
        [JsonIgnore]
        public virtual User User { get; set; }

        public int? ProjectID { get; set; }
        [JsonIgnore]
        public virtual Project Project { get; set; }

    }
}
