using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ex10.Models;

namespace ex10.Data
{
    public class ex10Context : DbContext
    {
        public ex10Context (DbContextOptions<ex10Context> options)
            : base(options)
        {
        }

        public DbSet<ex10.Models.Movie> Movie { get; set; }
    }
}
