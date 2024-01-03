using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Services.Concrete
{
    public class SpeakingLanguageService : Service<SpeakingLanguageEntity> , ISpeakingLanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISpeakingLanguageRepository _speakingLanguageRepository;
        public SpeakingLanguageService(IGenericRepository<SpeakingLanguageEntity> repository, IUnitOfWork unitOfWork, ISpeakingLanguageRepository speakingLanguageRepository) : base(unitOfWork,repository) 
        {
            _unitOfWork = unitOfWork;
            _speakingLanguageRepository = speakingLanguageRepository;
        }

        public async Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguages()
        {
            return await _speakingLanguageRepository.GetAllSpeakingLanguages();
        }

        public async Task<List<SpeakingLanguageEntity>> GetAllSpeakingLanguagesWithUsers()
        {
            return await _speakingLanguageRepository.GetAllSpeakingLanguagesWithUsers();
        }

        public async Task<SpeakingLanguageEntity> GetByIdSpeakingLanguage(int Id)
        {
            return await _speakingLanguageRepository.GetByIdSpeakingLanguage(Id);
        }

        public async Task<SpeakingLanguageEntity> GetByIdSpeakingLanguageWithUser(int Id)
        {
            return await _speakingLanguageRepository.GetByIdSpeakingLanguageWithUser(Id);
        }
    }
}
