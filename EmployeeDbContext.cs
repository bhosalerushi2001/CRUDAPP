using CRUDAPP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDAPP
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("DBCS")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}