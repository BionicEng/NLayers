using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class KnownProgramService
    {
        private readonly HttpClient _httpClient;
        public KnownProgramService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<KnownProgramViewModel>> GetAllKnownProgram()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<KnownProgramViewModel>>($"KnownProgram/GetAllKnownProgram");
            return response;
        }
        public async Task<KnownProgramViewModel> GetByIdKnownProgram(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<KnownProgramViewModel>($"KnownProgram/GetByIdKnownProgram?={Id}");
            return response;
        }
    }
}
