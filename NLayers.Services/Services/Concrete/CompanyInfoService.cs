using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Services.Concrete
{
    public class CompanyInfoService : Service<CompanyInfoEntity>, ICompanyInfoService
    {
        private readonly ICompanyInfoRepository _companyInfoRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CompanyInfoService(IGenericRepository<CompanyInfoEntity> repository,ICompanyInfoRepository companyInfoRepository, IUnitOfWork unitOfWork) : base(unitOfWork,repository)
        {
            _companyInfoRepository = companyInfoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoAsync()
        {
            return await _companyInfoRepository.GetAllCompanyInfoAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithRoleAsync()
        {
            return await _companyInfoRepository.GetAllCompanyInfoWithRoleAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserAsync()
        {
            return await _companyInfoRepository.GetAllCompanyInfoWithUserAsync();
        }

        public async Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserWithRoleAsync()
        {
            return await _companyInfoRepository.GetAllCompanyInfoWithUserWithRoleAsync();
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoAsync(int Id)
        {
            return await _companyInfoRepository.GetByIdCompanyInfoAsync(Id);
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithRoleAsync(int Id)
        {
            return await _companyInfoRepository.GetByIdCompanyInfoWithRoleAsync(Id);
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserAsync(int Id)
        {
            return await _companyInfoRepository.GetByIdCompanyInfoWithUserAsync(Id);
        }

        public async Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserWithRoleAsync(int Id)
        {
            return await _companyInfoRepository.GetByIdCompanyInfoWithUserWithRoleAsync(Id);
        }
    }
}
