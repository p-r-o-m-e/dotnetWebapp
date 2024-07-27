using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnetLearning.Models;

namespace dotnetLearning.Data
{
    public class dotnetLearningContext : DbContext
    {
        public dotnetLearningContext (DbContextOptions<dotnetLearningContext> options)
            : base(options)
        {
        }

        public DbSet<dotnetLearning.Models.Movie> Movie { get; set; } = default!;
    }
}
