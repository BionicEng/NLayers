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
    public class CompanyUserRoleRepository : GenericRepository<CompanyUserRoleEntity> , ICompanyUserRoleRepository
    {
        public CompanyUserRoleRepository(AppDbContext context) : base(context) { }

        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleAsync()
        {
            return await _context.CompanyUserRoleTable.ToListAsync();
        }

        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoAsync()
        {
            return await _context.CompanyUserRoleTable.Include(x => x.CompanyInfo).ToListAsync();
        }

        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoWithUserAsync()
        {
            return await _context.CompanyUserRoleTable.Include(x => x.CompanyInfo).ThenInclude(x=>x.User).ToListAsync();
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleAsync(int Id)
        {
            return await _context.CompanyUserRoleTable.SingleOrDefaultAsync(x=>x.Id == Id);
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoAsync(int Id)
        {
            return await _context.CompanyUserRoleTable.Include(x => x.CompanyInfo).SingleOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoWithUserAsync(int Id)
        {
            return await _context.CompanyUserRoleTable.Include(x => x.CompanyInfo).ThenInclude(x => x.User).SingleOrDefaultAsync(x => x.Id == Id);
        }
    }
}
