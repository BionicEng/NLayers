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
    public class CompanyInfoRepository : GenericRepository<CompanyInfoEntity>, ICompanyInfoRepository
    {
        public CompanyInfoRepository(AppDbContext context) : base(context) { }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoAsync()
        {
            return await _context.CompanyInfoTable.ToListAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithRoleAsync()
        {
            return await _context.CompanyInfoTable.Include(x=>x.UserRoles).ToListAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserAsync()
        {
            return await _context.CompanyInfoTable.Include(x => x.User).ToListAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserWithRoleAsync()
        {
            return await _context.CompanyInfoTable.Include(x => x.UserRoles).Include(x => x.User).ToListAsync();
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoAsync(int Id)
        {
            return await _context.CompanyInfoTable.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithRoleAsync(int Id)
        {
            return await _context.CompanyInfoTable.Include(x => x.UserRoles).Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserAsync(int Id)
        {
            return await _context.CompanyInfoTable.Include(x => x.User).Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserWithRoleAsync(int Id)
        {
            return await _context.CompanyInfoTable.Include(x => x.UserRoles).Include(x => x.User).Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}
