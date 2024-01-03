using Microsoft.EntityFrameworkCore;
using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Repository.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<List<UserEntity>> GetAllUserCertificates()
        {
            return await _context.UsersTable.Include(x=>x.Certificates).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserCompanyInfos()
        {
            return await _context.UsersTable.Include(x => x.CompanyInfos).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserCompanyInfosWithRole()
        {
            return await _context.UsersTable.Include(x => x.CompanyInfos).ThenInclude(x=>x.UserRoles).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserKnownPrograms()
        {
            return await _context.UsersTable.Include(x => x.KnownPrograms).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            return await _context.UsersTable.ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserSchoolInfos()
        {
            return await _context.UsersTable.Include(x => x.SchoolInfos).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserSchoolInfosWithDepartments()
        {
            return await _context.UsersTable.Include(x => x.SchoolInfos).ThenInclude(x => x.StudentDepartments).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserSpeakingLanguages()
        {
            return await _context.UsersTable.Include(x => x.Languages).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserUserAdress()
        {
            return await _context.UsersTable.Include(x => x.UserAdress).ToListAsync();
        }

        public async Task<List<UserEntity>> GetAllUserUserInformation()
        {
            return await _context.UsersTable.Include(x => x.UserInfo).ToListAsync();
        }

        public async Task<UserEntity> GetByIdUser(int Id)
        {
            return await _context.UsersTable.SingleOrDefaultAsync(x=>x.UserId == Id);
        }

        public async Task<UserEntity> GetByIdUserCertificates(int Id)
        {
            return await _context.UsersTable.Include(x => x.Certificates).Where(x=>x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserCompanyInfos(int Id)
        {
            return await _context.UsersTable.Include(x => x.CompanyInfos).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserCompanyInfosWithRole(int Id)
        {
            return await _context.UsersTable.Include(x => x.CompanyInfos).ThenInclude(x=>x.UserRoles).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserKnownPrograms(int Id)
        {
            return await _context.UsersTable.Include(x => x.KnownPrograms).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserSchoolInfos(int Id)
        {
            return await _context.UsersTable.Include(x => x.SchoolInfos).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserSchoolInfosWithDepartments(int Id)
        {
            return await _context.UsersTable.Include(x => x.SchoolInfos).ThenInclude(x => x.StudentDepartments).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserSpeakingLanguages(int Id)
        {
            return await _context.UsersTable.Include(x => x.Languages).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserUserAdress(int Id)
        {
            return await _context.UsersTable.Include(x => x.UserAdress).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }

        public async Task<UserEntity> GetByIdUserUserInformation(int Id)
        {
            return await _context.UsersTable.Include(x => x.UserInfo).Where(x => x.UserId == Id).SingleOrDefaultAsync();
        }
    }
}
