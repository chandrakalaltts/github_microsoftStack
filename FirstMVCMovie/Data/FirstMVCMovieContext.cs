using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCMovie.Data
{
    public class FirstMVCMovieContext :DbContext
    {
        public FirstMVCMovieContext(DbContextOptions<FirstMVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<FirstMVCMovieContext> Movie { get; set; }
    }
}
