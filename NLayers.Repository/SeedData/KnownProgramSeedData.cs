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
    public class KnownProgramSeedData : IEntityTypeConfiguration<KnownProgramEntity>
    {
        public void Configure(EntityTypeBuilder<KnownProgramEntity> builder)
        {
            builder.HasData(
                            new KnownProgramEntity()
                            {
                                Id = 1,
                                ProgramName = "Test1",
                                ProgramDescription = "Test1",
                                UserId = 2,


                            },
                            new KnownProgramEntity()
                            {
                                Id = 2,
                                ProgramName = "Test2",
                                ProgramDescription = "Test2",
                                UserId = 3,


                            },
                            new KnownProgramEntity()
                            {
                                Id = 3,
                                ProgramName = "Test3",
                                ProgramDescription = "Test3",
                                UserId = 1,


                            });
        }

    }

}
