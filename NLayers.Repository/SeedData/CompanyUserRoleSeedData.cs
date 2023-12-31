using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayers.Core.Entities;

namespace NLayers.Repository.SeedData
{
    public class CompanyUserRoleSeedData : IEntityTypeConfiguration<CompanyUserRoleEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyUserRoleEntity> builder)
        {
            builder.HasData(
                            new CompanyUserRoleEntity()
                            {
                                Id = 1,
                                UserRoleName = "Test1",
                                UserRoleDescription = "Test1",
                                CompanyInfosId = 1,
                            },
                            new CompanyUserRoleEntity()
                            {
                                Id = 2,
                                UserRoleName = "Test2",
                                UserRoleDescription = "Test2",
                                CompanyInfosId = 5,
                            },

                            new CompanyUserRoleEntity()
                            {
                                Id = 3,
                                UserRoleName = "Test3",
                                UserRoleDescription = "Test3",
                                CompanyInfosId = 5,
                            },
                             new CompanyUserRoleEntity()
                             {
                                 Id = 4,
                                 UserRoleName = "Test4",
                                 UserRoleDescription = "Test4",
                                 CompanyInfosId = 4,
                             },
                            new CompanyUserRoleEntity()
                            {
                                Id = 5,
                                UserRoleName = "Test5",
                                UserRoleDescription = "Test5",
                                CompanyInfosId = 4,
                            },
                            new CompanyUserRoleEntity()
                            {
                                Id = 6,
                                UserRoleName = "Test6",
                                UserRoleDescription = "Test6",
                                CompanyInfosId = 1,
                            },
                            new CompanyUserRoleEntity()
                            {
                                Id = 7,
                                UserRoleName = "Test7",
                                UserRoleDescription = "Test7",

                            });

        }

    }
}
