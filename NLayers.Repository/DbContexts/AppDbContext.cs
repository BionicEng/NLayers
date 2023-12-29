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
        public DbSet<CompanyInfoEntity> CompanyInfoTable { get; set;}
        public DbSet<CompanyUserRoleEntity> CompanyUserRoleTable { get; set;}
        public DbSet<KnownProgramEntity> KnownProgramTable { get; set; }
        public DbSet<SchoolInformationEntity> SchoolInformationTable { get;set; }
        public DbSet<SpeakingLanguageEntity> SpeakingLanguagesTable { get; set; }
        public DbSet<StudentDepartmentEntity> StudentDepartmentTable { get; set;}
        public DbSet<UserAdressEntity> UserAdressTable { get; set;}
        public DbSet<UserInformationEntity> UserInformationTable { get; set; }

    }
}
