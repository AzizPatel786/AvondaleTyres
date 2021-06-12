using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvondaleTyres.Models;
using Microsoft.EntityFrameworkCore;

namespace AvondaleTyres.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
