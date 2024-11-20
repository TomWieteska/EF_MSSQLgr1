using EF_MSSQLgr1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MSSQLgr1.Configurationns
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {

        public UserConfiguration() {

            ToTable("dbo.Users");
            HasKey(x=>x.Id);

            Property(x=>x.FirsName).IsRequired();
            Property(x => x.FirsName).HasMaxLength(20);
            Property(x=>x.LastName).IsRequired();


        }
    }
}
