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

    public class SchoolDepartmentSeedData : IEntityTypeConfiguration<SchoolDepartmentEntity>
    {
        public void Configure(EntityTypeBuilder<SchoolDepartmentEntity> builder)
        {
            builder.HasData(
                              new SchoolDepartmentEntity()
                              {
                                  Id = 1,
                                  DepartmentName = "Test1",
                                  DepartmentDescription = "Test1",
                                  SchoolsId = 2
                              },
                              new SchoolDepartmentEntity()
                              {
                                  Id = 2,
                                  DepartmentName = "Test2",
                                  DepartmentDescription = "Test2",
                                  SchoolsId = 3,
                              },
                              new SchoolDepartmentEntity()
                              {
                                  Id = 3,
                                  DepartmentName = "Test3",
                                  DepartmentDescription = "Test3",
                                  SchoolsId = 1,
                              });

        }

    }

}
