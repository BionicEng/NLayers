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
    public class UserAdressSeedData : IEntityTypeConfiguration<UserAdressEntity>
    {
        public void Configure(EntityTypeBuilder<UserAdressEntity> builder)
        {
            builder.HasData(
                    new UserAdressEntity()
                    {
                        Id = 1,
                        CityName = "Ankara/Sincan",
                        PostalCode = "12345",
                        Country = "Türkiye",
                        State = "A Mah",
                        StreetName = "12345",
                    },

                    new UserAdressEntity()
                    {
                        Id = 2,
                        CityName = "Ankara/Yenimahalle",
                        PostalCode = "12345",
                        Country = "Türkiye",
                        State = "B Mah",
                        StreetName = "12345",
                    },
                    new UserAdressEntity()
                    {
                        Id = 3,
                        CityName = "Ankara/Ostim",
                        PostalCode = "12345",
                        Country = "Türkiye",
                        State = "C Mah",
                        StreetName = "12345",
                    });
        }

    }
}
