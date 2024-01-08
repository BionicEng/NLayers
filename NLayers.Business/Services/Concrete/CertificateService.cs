using NLayers.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class CertificateService
    {
        private readonly HttpClient _httpClient;
        public CertificateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<ICollection<CertificateViewModel>> GetAllCertificates()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<CertificateViewModel>>($"Certificate/GetAllCertificates");
            return response;
        }
        public async Task<CertificateViewModel> GetByIdCertificate(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<CertificateViewModel>($"Certificate/GetByIdCertificate?={Id}");
            return response;
        }
        public async Task<CertificateViewModel> AddCertificate(CertificateViewModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("Certificate/AddCertificate", model);
            return model;
        }
        public async Task<CertificateViewModel> UpdateNews(CertificateViewModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("Certificate/UpdateCertificate", model);
            return model;
        }
        public async Task<int> DeleteNews(int id)
        {
            var response = await _httpClient.PostAsJsonAsync("Certificate/DeleteCertificate", id);
            return id;
        }

    }
}
