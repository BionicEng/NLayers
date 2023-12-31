using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Repository.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasData(
                    new UserEntity()
                    {
                        UserId = 1,
                        FirstName = "AdminName",
                        LastName = "AdminLastName",
                        Email = "AdminEmail@email.com",
                        Password = "Admin",
                        PhoneNumber = "AdminPhoneNumber",
                        Roles = "Admin"
                    },
                    new UserEntity()
                    {
                        UserId = 2,
                        FirstName = "FirstName1",
                        LastName = "LastName1",
                        Email = "Email1@email.com",
                        Password = "Password1",
                        PhoneNumber = "PhoneNumber1",
                        Roles = "User"
                    },
                    new UserEntity()
                    {
                        UserId = 3,
                        FirstName = "FirstName2",
                        LastName = "LastName2",
                        Email = "Email2@email.com",
                        Password = "Password2",
                        PhoneNumber = "PhoneNumber2",
                        Roles = "User"
                    });

        }

    }
}
