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
    public class KnownProgramService : Service<KnownProgramEntity>, IKnownProgramService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IKnownProgramRepository _knownProgramRepository;
        public KnownProgramService(IGenericRepository<KnownProgramEntity> repository,IKnownProgramRepository knownProgramRepository, IUnitOfWork unitOfWork) : base(unitOfWork,repository)
        {
            _knownProgramRepository = knownProgramRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<KnownProgramEntity>> GetAllKnownPrograms()
        {
            return await _knownProgramRepository.GetAllKnownPrograms();
        }

        public async Task<List<KnownProgramEntity>> GetAllKnownProgramsWithUsers()
        {
            return await _knownProgramRepository.GetAllKnownProgramsWithUsers();
        }

        public async Task<KnownProgramEntity> GetByIdKnownProgram(int Id)
        {
            return await _knownProgramRepository.GetByIdKnownProgram(Id);
        }

        public async Task<KnownProgramEntity> GetByIdKnownProgramWithUser(int Id)
        {
            return await _knownProgramRepository.GetByIdKnownProgramWithUser(Id);
        }
    }
}
