using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Repositories
{
    public interface ISpeakingLanguageRepository : IGenericRepository<SpeakingLanguageEntity>
    {
        Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguages();
        Task<SpeakingLanguageEntity> GetByIdSpeakingLanguage(int Id);
        Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguagesWithUsers();
        Task<SpeakingLanguageEntity> GetByIdSpeakingLanguageWithUser(int Id);
    }
}
