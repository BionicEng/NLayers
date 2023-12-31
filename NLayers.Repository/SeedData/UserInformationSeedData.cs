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
    public class UserInformationSeedData : IEntityTypeConfiguration<UserInformationEntity>
    {
        public void Configure(EntityTypeBuilder<UserInformationEntity> builder)
        {
            builder.HasData(
                    new UserInformationEntity()
                    {
                        Id = 1,
                        Gender = "Male",
                        BirtDay = new DateTime(2023, 12, 25),
                        Hobies = "Hobies A",
                        UserDescription = "Description A",
                        MSwasDone = true,

                    },
                    new UserInformationEntity()
                    {
                        Id = 2,
                        Gender = "Male",
                        BirtDay = new DateTime(2023, 12, 25),
                        Hobies = "Hobies b",
                        UserDescription = "Description b",
                        MSwasDone = true,

                    },
                    new UserInformationEntity()
                    {
                        Id = 3,
                        Gender = "Male",
                        BirtDay = new DateTime(2023, 12, 25),
                        Hobies = "Hobies c",
                        UserDescription = "Description c",
                        MSwasDone = true
                    });

        }

    }
}
