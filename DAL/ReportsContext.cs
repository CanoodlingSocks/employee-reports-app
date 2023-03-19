using DAL.SQLModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportsContext : DbContext
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Managers> Managers { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename= ./ReportsDB.sqlite");
        }
    }
}
