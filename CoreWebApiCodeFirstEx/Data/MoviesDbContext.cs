using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreWebApiCodeFirstEx.Models;

namespace CoreWebApiCodeFirstEx.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<CoreWebApiCodeFirstEx.Models.Movie> Movie { get; set; }
    }
}
