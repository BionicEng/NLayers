using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class CompanyInfoService
    {
        private readonly HttpClient _httpClient;
        public CompanyInfoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<CompanyInfoViewModel>> GetAllCompanyInfo()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<CompanyInfoViewModel>>($"CompanyInfo/GetAllCompanyInfo");
            return response;
        }
        public async Task<CompanyInfoViewModel> GetByIdCompanyInfo(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<CompanyInfoViewModel>($"CompanyInfo/GetByIdCompanyInfo?={Id}");
            return response;
        }
    }
}
