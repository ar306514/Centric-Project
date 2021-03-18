using CentricProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CentricProject.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Position> position { get; set; }
    }

}