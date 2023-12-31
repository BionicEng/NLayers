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
    public class SpeakingLanguageSeedData : IEntityTypeConfiguration<SpeakingLanguageEntity>
    {
        public void Configure(EntityTypeBuilder<SpeakingLanguageEntity> builder)
        {
            builder.HasData(
                            new SpeakingLanguageEntity()
                            {
                                Id = 1,
                                LanguageName = "Test1",
                                LanguageDescription = "Test1",
                                UserId = 2,


                            },
                            new SpeakingLanguageEntity()
                            {
                                Id = 2,
                                LanguageName = "Test2",
                                LanguageDescription = "Test2",
                                UserId = 3,


                            },
                            new SpeakingLanguageEntity()
                            {
                                Id = 3,
                                LanguageName = "Test3",
                                LanguageDescription = "Test3",
                                UserId = 1,


                            });
        }

    }
}
