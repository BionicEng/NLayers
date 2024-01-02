using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Services.Abstract
{
    public interface ICompanyInfoService : IService<CompanyInfoEntity>
    {
        public Task<List<CompanyInfoEntity>> GetAllCompanyInfoAsync();
        public Task<CompanyInfoEntity> GetByIdCompanyInfoAsync(int Id);

        public Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithRoleAsync();
        public Task<CompanyInfoEntity> GetByIdCompanyInfoWithRoleAsync(int Id);

        public Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserAsync();
        public Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserAsync(int Id);

        public Task<List<CompanyInfoEntity>> GetAllCompanyInfoWithUserWithRoleAsync();
        public Task<CompanyInfoEntity> GetByIdCompanyInfoWithUserWithRoleAsync(int Id);
    }
}
