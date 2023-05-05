using ErdincHocaCozumAss15.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Configuration
{
    internal class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x=>x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.UserName).HasMaxLength(100);
            builder.Property(x => x.Password).HasMaxLength(100);
            builder.Property(x=> x.IsActive).HasDefaultValue(false);

            // 02.05.23 14:07 aşağıdaki gibi yazarsak hep bu tarih atılacak. ctorda yazmalıyız!!!
           // builder.Property(x=> x.CreationDate).HasDefaultValue(DateTime.Now); 


            builder.HasData(
                new User()
                {
                    Id =1,
                    IsActive= true,
                    FirstName = "Bilge",
                    LastName = "Adam",
                    UserName = "admin",
                    Password = "admin123",
                    UserType = Enum.UserType.Admin,
                }
                );

        }
    }
}
