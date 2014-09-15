using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GSPNewProject.Models
{
    public class ProjectContext : DbContext
    {
        static ProjectContext()
        {
            Database.SetInitializer<ProjectContext>(null);
        }

        public ProjectContext()
            : base("Name=DefaultConnection")
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}