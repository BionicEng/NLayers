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
    public class SchoolDepartmentRepository : GenericRepository<SchoolDepartmentEntity>, ISchoolDepartmentRepository
    {
        public SchoolDepartmentRepository(AppDbContext context) : base(context) { }

        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentAsync()
        {
            return await _context.SchoolDepartmentTable.ToListAsync();
        }

        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoAsync()
        {
            return await _context.SchoolDepartmentTable.Include(x=>x.Schools).ToListAsync();
        }

        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoWithUserAsync()
        {
            return await _context.SchoolDepartmentTable.Include(x => x.Schools).ThenInclude(x=>x.User).ToListAsync();
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentAsync(int Id)
        {
            return await _context.SchoolDepartmentTable.Where(x=>x.Id == Id).SingleOrDefaultAsync();
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoAsync(int Id)
        {
            return await _context.SchoolDepartmentTable.Include(x => x.Schools).Where(x => x.Id == Id).SingleOrDefaultAsync();
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoWithUserAsync(int Id)
        {
            return await _context.SchoolDepartmentTable.Include(x => x.Schools).ThenInclude(x => x.User).Where(x => x.Id == Id).SingleOrDefaultAsync();
        }
    }
}
