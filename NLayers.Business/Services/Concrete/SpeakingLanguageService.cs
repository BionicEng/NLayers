using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class SpeakingLanguageService
    {
        private readonly HttpClient _httpClient;
        public SpeakingLanguageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<SpeakingLanguageViewModel>> GetAllSpeakingLanguage()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<SpeakingLanguageViewModel>>($"SpeakingLanguage/GetAllSpeakingLanguage");
            return response;
        }
        public async Task<SpeakingLanguageViewModel> GetByIdSpeakingLanguage(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<SpeakingLanguageViewModel>($"SpeakingLanguage/GetByIdSpeakingLanguage?={Id}");
            return response;
        }
    }
}
