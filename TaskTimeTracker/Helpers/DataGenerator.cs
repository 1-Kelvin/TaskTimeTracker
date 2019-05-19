using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimeTracker.Helpers
{
    public class DataGenerator
    {
        private ModelBuilder _modelBuilder;

        public DataGenerator (ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }


    }
}
