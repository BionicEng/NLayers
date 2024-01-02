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
    public class CompanyUserRoleService : Service<CompanyUserRoleEntity>, ICompanyUserRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICompanyUserRoleRepository _companyUserRoleRepository;
        public CompanyUserRoleService(IGenericRepository<CompanyUserRoleEntity> repository , IUnitOfWork unitOfWork, ICompanyUserRoleRepository companyUserRoleRepository) : base(unitOfWork,repository)
        {
            _unitOfWork = unitOfWork;
            _companyUserRoleRepository = companyUserRoleRepository;
        }
        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleAsync()
        {
            return await _companyUserRoleRepository.GetAllCompanyUserRoleAsync();
        }

        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoAsync()
        {
            return await _companyUserRoleRepository.GetAllCompanyUserRoleWithCompanyInfoAsync();
        }

        public async Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoWithUserAsync()
        {
            return await _companyUserRoleRepository.GetAllCompanyUserRoleWithCompanyInfoWithUserAsync();
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleAsync(int Id)
        {
            return await _companyUserRoleRepository.GetByIdCompanyUserRoleAsync(Id);
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoAsync(int Id)
        {
            return await _companyUserRoleRepository.GetByIdCompanyUserRoleWithCompanyInfoAsync(Id);
        }

        public async Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoWithUserAsync(int Id)
        {
            return await _companyUserRoleRepository.GetByIdCompanyUserRoleWithCompanyInfoWithUserAsync(Id);
        }
    }
}
