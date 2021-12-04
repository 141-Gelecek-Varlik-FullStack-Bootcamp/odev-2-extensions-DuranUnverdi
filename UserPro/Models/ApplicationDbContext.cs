using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPro.Models
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LI8CF0L\\SQLEXPRESS;database=PatikaUser;integrated security=true");
        }
        public DbSet<Log> Logs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
