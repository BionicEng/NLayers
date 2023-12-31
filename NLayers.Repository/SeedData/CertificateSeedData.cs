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
    public class CertificateSeedData : IEntityTypeConfiguration<CertificateEntity>
    {
        public void Configure(EntityTypeBuilder<CertificateEntity> builder)
        {
            builder.HasData(
                        new CertificateEntity()
                        {
                            Id = 1,
                            UserId = 1,
                            CertificateName = "Test1",
                            CertificateDescription = "Test",
                            FileName = "Test",
                            FilePath = "Test",
                            CreatedAt = DateTime.Now
                        },
                        new CertificateEntity()
                        {
                            Id = 2,
                            UserId = 1,
                            CertificateName = "Test2",
                            CertificateDescription = "Test",
                            FileName = "Test",
                            FilePath = "Test",
                            CreatedAt = DateTime.Now
                        },
                        new CertificateEntity()
                        {
                            Id = 3,
                            UserId = 1,
                            CertificateName = "Test3",
                            CertificateDescription = "Test",
                            FileName = "Test",
                            FilePath = "Test",
                            CreatedAt = DateTime.Now
                        },
                        new CertificateEntity()
                        {
                            Id = 4,
                            UserId = 2,
                            CertificateName = "Test4",
                            CertificateDescription = "Test",
                            FileName = "Test",
                            FilePath = "Test",
                            CreatedAt = DateTime.Now
                        },
                        new CertificateEntity()
                        {
                            Id = 5,
                            UserId = 3,
                            CertificateName = "Test5",
                            CertificateDescription = "Test",
                            FileName = "Test",
                            FilePath = "Test",
                            CreatedAt = DateTime.Now
                        });

        }

    }
}
