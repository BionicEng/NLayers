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
    public class SchoolInformationService : Service<SchoolInformationEntity>, ISchoolInformationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISchoolInformationRepository _schoolInformationRepository;
        public SchoolInformationService(IGenericRepository<SchoolInformationEntity> repository, IUnitOfWork unitOfWork, ISchoolInformationRepository schoolInformationRepository) : base(unitOfWork,repository)
        {
            _unitOfWork = unitOfWork;
            _schoolInformationRepository = schoolInformationRepository;
        }
        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformations()
        {
            return await _schoolInformationRepository.GetAllSchoolInformations();
        }
        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithDepartments()
        {
            return await _schoolInformationRepository.GetAllSchoolInformationsWithDepartments();
        }
        public async Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithUser()
        {
            return await _schoolInformationRepository.GetAllSchoolInformationsWithUser();
        }
        public async Task<SchoolInformationEntity> GetSchoolInformationById(int id)
        {
            return await _schoolInformationRepository.GetSchoolInformationById(id);
        }
        public async Task<SchoolInformationEntity> GetSchoolInformationWithDepartmentsById(int id)
        {
            return await _schoolInformationRepository.GetSchoolInformationWithDepartmentsById(id);
        }
        public async Task<SchoolInformationEntity> GetSchoolInformationWithUserById(int id)
        {
            return await _schoolInformationRepository.GetSchoolInformationWithUserById(id);
        }
    }
}
