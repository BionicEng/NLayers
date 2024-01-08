using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class SchoolInformationService
    {
        private readonly HttpClient _httpClient;
        public SchoolInformationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<SchoolInformationViewModel>> GetAllSchoolInformations()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<SchoolInformationViewModel>>($"SchoolInformation/GetAllSchoolInformations");
            return response;
        }
        public async Task<SchoolInformationViewModel> GetByIdSchoolInformation(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<SchoolInformationViewModel>($"SchoolInformation/GetByIdSchoolDepartment?={Id}");
            return response;
        }
    }
}
