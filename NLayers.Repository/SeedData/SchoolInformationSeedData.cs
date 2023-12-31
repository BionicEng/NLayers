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

    public class SchoolInformationSeedData : IEntityTypeConfiguration<SchoolInformationEntity>
    {
        public void Configure(EntityTypeBuilder<SchoolInformationEntity> builder)
        {
            builder.HasData(
                              new SchoolInformationEntity()
                              {
                                  Id = 1,
                                  SchoolName = "Test1",
                                  SchoolDescription = "Test1",
                                  Location = "Test1",
                                  UserId = 2,
                              },
                              new SchoolInformationEntity()
                              {
                                  Id = 2,
                                  SchoolName = "Test2",
                                  SchoolDescription = "Test2",
                                  Location = "Test2",
                                  UserId = 3,
                              },
                              new SchoolInformationEntity()
                              {
                                  Id = 3,
                                  SchoolName = "Test3",
                                  SchoolDescription = "Test3",
                                  Location = "Test3",
                                  UserId = 1,
                              });
        }

    }
}
