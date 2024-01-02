using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Services.Abstract
{
    public interface ICompanyUserRoleService : IService<CompanyUserRoleEntity>
    {
        public Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleAsync();
        public Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleAsync(int Id);

        public Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoAsync();
        public Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoAsync(int Id);

        public Task<List<CompanyUserRoleEntity>> GetAllCompanyUserRoleWithCompanyInfoWithUserAsync();
        public Task<CompanyUserRoleEntity> GetByIdCompanyUserRoleWithCompanyInfoWithUserAsync(int Id);
    }
}
