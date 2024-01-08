using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class SchoolDepartmentService
    {
        private readonly HttpClient _httpClient;
        public SchoolDepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<SchoolDepartmentViewModel>> GetAllSchoolDepartment()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<SchoolDepartmentViewModel>>($"SchoolDepartment/GetAllSchoolDepartment");
            return response;
        }
        public async Task<SchoolDepartmentViewModel> GetByIdSchoolDepartment(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<SchoolDepartmentViewModel>($"SchoolDepartment/GetByIdSchoolDepartment?={Id}");
            return response;
        }
    }
}
