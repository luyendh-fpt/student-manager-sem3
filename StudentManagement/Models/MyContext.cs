using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyConnection")
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}