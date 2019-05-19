﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.DTOs
{
    public class ViewProjectDTO
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        [Required, MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
    }
}
