﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.DTOs
{
    public class ViewUserDTO
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
    }
}