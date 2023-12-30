using Microsoft.EntityFrameworkCore;
using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Repository.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserEntity> UsersTable { get; set; }
        public DbSet<CertificateEntity> CertificatesTable { get; set; }
        public DbSet<CompanyInfoEntity> CompanyInfoTable { get; set; }
        public DbSet<CompanyUserRoleEntity> CompanyUserRoleTable { get; set; }
        public DbSet<KnownProgramEntity> KnownProgramTable { get; set; }
        public DbSet<SchoolInformationEntity> SchoolInformationTable { get; set; }
        public DbSet<SpeakingLanguageEntity> SpeakingLanguagesTable { get; set; }
        public DbSet<SchoolDepartmentEntity> SchoolDepartmentTable { get; set; }
        public DbSet<UserAdressEntity> UserAdressTable { get; set; }
        public DbSet<UserInformationEntity> UserInformationTable { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasData(
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

            modelBuilder.Entity<UserAdressEntity>()
                .HasData(
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
            modelBuilder.Entity<UserInformationEntity>()
                .HasData(
                    new UserInformationEntity () 
                    {
                        Id= 1,
                        Gender = "Male",
                        BirtDay = new DateTime(2023,12,25),
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
            modelBuilder.Entity<CertificateEntity>()
                .HasData(
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
