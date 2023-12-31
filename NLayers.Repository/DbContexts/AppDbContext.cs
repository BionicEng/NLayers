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
            modelBuilder.Entity<CompanyInfoEntity>()
                        .HasData(
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
            modelBuilder.Entity<CompanyUserRoleEntity>()
                            .HasData(
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
            modelBuilder.Entity<KnownProgramEntity>()
                            .HasData(
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
            modelBuilder.Entity<SpeakingLanguageEntity>()
                            .HasData(
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
            modelBuilder.Entity<SchoolInformationEntity>()
                             .HasData(
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
            modelBuilder.Entity<SchoolDepartmentEntity>()
                             .HasData(
                              new SchoolDepartmentEntity()
                              {
                                  Id = 1,
                                  DepartmentName = "Test1",
                                  DepartmentDescription = "Test1",
                                  SchoolsId = 2,
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
