using EF_MSSQLgr1.Configurationns;
using EF_MSSQLgr1.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace EF_MSSQLgr1
{
    public class AppDBContext : DbContext
    {
        
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }


    }

}