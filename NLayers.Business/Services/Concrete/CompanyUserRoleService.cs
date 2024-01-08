using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class CompanyUserRoleService
    {
        private readonly HttpClient _httpClient;
        public CompanyUserRoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<CompanyUserRoleViewModel>> GetAllCompanyUserRole()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<CompanyUserRoleViewModel>>($"CompanyUserRole/GetAllCompanyUserRole");
            return response;
        }
        public async Task<CompanyUserRoleViewModel> GetByIdCompanyUserRole(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<CompanyUserRoleViewModel>($"CompanyUserRole/GetByIdCompanyUserRole?={Id}");
            return response;
        }
    }
}
