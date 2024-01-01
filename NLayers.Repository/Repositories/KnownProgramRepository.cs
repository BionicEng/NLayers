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
    public class KnownProgramRepository : GenericRepository<KnownProgramEntity>, IKnownProgramRepository
    {
        public KnownProgramRepository(AppDbContext context) : base(context) { }

        public async Task<List<KnownProgramEntity>> GetAllKnownPrograms()
        {
            return await _context.KnownProgramTable.ToListAsync();
        }

        public async Task<List<KnownProgramEntity>> GetAllKnownProgramsWithUsers()
        {
            return await _context.KnownProgramTable.Include(x=>x.User).ToListAsync();
        }

        public async Task<KnownProgramEntity> GetByIdKnownProgram(int Id)
        {
            return await _context.KnownProgramTable.Where(x => x.Id == Id).SingleOrDefaultAsync();
        }

        public async Task<KnownProgramEntity> GetByIdKnownProgramWithUser(int Id)
        {
            return await _context.KnownProgramTable.Include(x => x.User).Where(x => x.Id == Id).SingleOrDefaultAsync();
        }
    }
}
