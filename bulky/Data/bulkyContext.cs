using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bulky.Models;

namespace bulky.Data
{
    public class bulkyContext : DbContext
    {
        public bulkyContext (DbContextOptions<bulkyContext> options)
            : base(options)
        {
        }

        public DbSet<bulky.Models.Movie> Movie { get; set; } = default!;
    }
}
