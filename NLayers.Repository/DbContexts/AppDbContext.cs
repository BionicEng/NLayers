using Microsoft.EntityFrameworkCore;
using NLayers.Core.Entities;
using NLayers.Repository.SeedData;
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
            modelBuilder.ApplyConfiguration(new UserSeedData());
            modelBuilder.ApplyConfiguration(new CertificateSeedData());
            modelBuilder.ApplyConfiguration(new CompanyInfoSeedData());
            modelBuilder.ApplyConfiguration(new CompanyUserRoleSeedData());
            modelBuilder.ApplyConfiguration(new KnownProgramSeedData());
            modelBuilder.ApplyConfiguration(new SchoolDepartmentSeedData());
            modelBuilder.ApplyConfiguration(new SchoolInformationSeedData());
            modelBuilder.ApplyConfiguration(new SpeakingLanguageSeedData());
            modelBuilder.ApplyConfiguration(new UserAdressSeedData());
            modelBuilder.ApplyConfiguration(new UserInformationSeedData());
        }

    }
}
