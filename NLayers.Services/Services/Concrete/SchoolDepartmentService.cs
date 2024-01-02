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
    public class SchoolDepartmentService : Service<SchoolDepartmentEntity>, ISchoolDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISchoolDepartmentRepository _schoolDepartmentRepository;
        public SchoolDepartmentService(IGenericRepository<SchoolDepartmentEntity> repository, IUnitOfWork unitOfWork , ISchoolDepartmentRepository schoolDepartmentRepository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _schoolDepartmentRepository = schoolDepartmentRepository;
        }
        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentAsync()
        {
            return await _schoolDepartmentRepository.GetAllSchoolDepartmentAsync();
        }

        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoAsync()
        {
            return await _schoolDepartmentRepository.GetAllSchoolDepartmentWithSchoolInfoAsync();
        }

        public async Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoWithUserAsync()
        {
            return await _schoolDepartmentRepository.GetAllSchoolDepartmentWithSchoolInfoWithUserAsync();
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentAsync(int Id)
        {
            return await _schoolDepartmentRepository.GetByIdSchoolDepartmentAsync(Id);
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoAsync(int Id)
        {
            return await _schoolDepartmentRepository.GetByIdSchoolDepartmentWithSchoolInfoAsync(Id);
        }

        public async Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoWithUserAsync(int Id)
        {
            return await _schoolDepartmentRepository.GetByIdSchoolDepartmentWithSchoolInfoWithUserAsync(Id);
        }
    }
}
