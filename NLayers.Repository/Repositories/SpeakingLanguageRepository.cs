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
    public class SpeakingLanguageRepository : GenericRepository<SpeakingLanguageEntity>, ISpeakingLanguageRepository
    {
        public SpeakingLanguageRepository(AppDbContext context) : base(context) { }

        public async Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguages()
        {
            return await _context.SpeakingLanguagesTable.ToListAsync();
        }

        public async Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguagesWithUsers()
        {
            return await _context.SpeakingLanguagesTable.Include(x=>x.User).ToListAsync();
        }

        public async Task<SpeakingLanguageEntity> GetByIdSpeakingLanguage(int Id)
        {
            return await _context.SpeakingLanguagesTable.Where(x=>x.Id == Id).SingleOrDefaultAsync();
        }

        public async Task<SpeakingLanguageEntity> GetByIdSpeakingLanguageWithUser(int Id)
        {
            return await _context.SpeakingLanguagesTable.Include(x=>x.UserId).Where(x => x.Id == Id).SingleOrDefaultAsync();
        }
    }
}
