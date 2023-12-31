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
    public class CompanyInfoSeedData : IEntityTypeConfiguration<CompanyInfoEntity>
    { 
        public void Configure(EntityTypeBuilder<CompanyInfoEntity> builder)
        {
            builder.HasData(
                        new CompanyInfoEntity()
                        {
                            Id = 1,
                            CompanyName = "Test1",
                            CompanyDescription = "Test1",
                            FileName = "Test1",
                            FilePath = "Test1",
                            CompanyField = "Test1",
                            CompanyAddress = "Test1",
                            UserId = 1

                        },
                         new CompanyInfoEntity()
                         {
                             Id = 2,
                             CompanyName = "Test2",
                             CompanyDescription = "Test2",
                             FileName = "Test2",
                             FilePath = "Test2",
                             CompanyField = "Test2",
                             CompanyAddress = "Test2",
                             UserId = 1
                         },
                          new CompanyInfoEntity()
                          {
                              Id = 3,
                              CompanyName = "Test3",
                              CompanyDescription = "Test3",
                              FileName = "Test3",
                              FilePath = "Test3",
                              CompanyField = "Test3",
                              CompanyAddress = "Test3",
                              UserId = 1
                          },
                           new CompanyInfoEntity()
                           {
                               Id = 4,
                               CompanyName = "Test4",
                               CompanyDescription = "Test4",
                               FileName = "Test4",
                               FilePath = "Test4",
                               CompanyField = "Test4",
                               CompanyAddress = "Test4",
                               UserId = 2
                           },
                            new CompanyInfoEntity()
                            {
                                Id = 5,
                                CompanyName = "Test5",
                                CompanyDescription = "Test5",
                                FileName = "Test5",
                                FilePath = "Test5",
                                CompanyField = "Test5",
                                CompanyAddress = "Test5",
                                UserId = 3
                            });

        }

    }
}
