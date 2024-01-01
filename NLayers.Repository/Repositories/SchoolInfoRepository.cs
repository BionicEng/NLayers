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
    public class SchoolInfoRepository : GenericRepository<SchoolInformationEntity>, ISchoolInformationRepository
    {
        public SchoolInfoRepository(AppDbContext _context) : base(_context) { }
        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformations()
        {
            return await _context.SchoolInformationTable.ToListAsync();
        }

        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithDepartments()
        {
            return await _context.SchoolInformationTable.Include(x => x.StudentDepartments).ToListAsync();
        }

        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithUser()
        {
            return await _context.SchoolInformationTable.Include(x => x.User).ToListAsync();
        }

        public async Task<SchoolInformationEntity> GetSchoolInformationById(int id)
        {
            return await _context.SchoolInformationTable.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<SchoolInformationEntity> GetSchoolInformationWithDepartmentsById(int id)
        {
            return await _context.SchoolInformationTable.Include(x => x.StudentDepartments).Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<SchoolInformationEntity> GetSchoolInformationWithUserById(int id)
        {
            return await _context.SchoolInformationTable.Include(x => x.User).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
