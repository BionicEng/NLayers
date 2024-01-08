using NLayers.Business.Models;using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Services.Concrete
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<ICollection<UserWithCertificatesViewModel>> GetAllUserWithCertificates()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithCertificatesViewModel>>($"User/GetAllUsersWithCertificates");
            return response;
        }
        public async Task<UserWithCertificatesViewModel> GetByIdUserWithCertificates(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithCertificatesViewModel>($"User/GetByIdUserWithCertificates?={Id}");
            return response;
        }

        public async Task<ICollection<UserViewModel>> GetAllUsers()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserViewModel>>($"User/GetAllUsers");
            return response;
        }

        public async Task<UserViewModel> GetByIdUser(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserViewModel>($"User/GetByIdUser?={Id}");
            return response;
        }

        public async Task<ICollection<UserWithCompanyInfoViewModel>> GetAllUserWithCompanyInfos()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithCompanyInfoViewModel>>($"User/GetAllUsersWithCompanyInfos");
            return response;
        }
        public async Task<UserWithCompanyInfoViewModel> GetByIdUserWithCompanyInfo(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithCompanyInfoViewModel>($"User/GetByIdUserWithCompanyInfos?={Id}");
            return response;
        }
        public async Task<ICollection<UserWithCompanyInfoViewModel>> GetAllUserWithCompanyInfosWithRoles()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithCompanyInfoViewModel>>($"User/GetAllUsersWithCompanyInfosWithRole");
            return response;
        }
        public async Task<UserWithCompanyInfoViewModel> GetByIdUserWithCompanyInfosWithRole(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithCompanyInfoViewModel>($"User/GetByIdUserWithCompanyInfosWithRole?={Id}");
            return response;
        }
        public async Task<ICollection<UserWithKnownProgramsViewModel>> GetAllUsersWithKnownPrograms() 
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithKnownProgramsViewModel>>($"User/GetAllUsersWithKnownPrograms");
            return response;
        }
        public async Task<UserWithKnownProgramsViewModel> GetByIdUserWithKnownPrograms(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithKnownProgramsViewModel>($"User/GetByIdUserKnownPrograms?={Id}");
            return response;
        }
        public async Task<ICollection<UserWithSchoolInfosViewModel>> GetAllUsersWithSchoolInfos()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithSchoolInfosViewModel>>($"User/GetAllUsersWithSchoolInfos");
            return response;
        }
        public async Task<UserWithSchoolInfosViewModel> GetByIdUserWithSchoolInfos(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithSchoolInfosViewModel>($"User/GetByIdUserWithSchoolInfos?={Id}");
            return response;
        }
        public async Task<ICollection<UserWithSchoolInfosViewModel>> GetAllUsersWithSchoolInfosWithDepartments()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithSchoolInfosViewModel>>($"User/GetAllUsersWithSchoolInfosWithDepartments");
            return response;
        }
        public async Task<UserWithSchoolInfosViewModel> GetByIdUserWithSchoolInfosWithDepartments(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithSchoolInfosViewModel>($"User/GetByIdUserWithSchoolInfosWithDepartments?={Id}");
            return response;
        }
        public async Task<ICollection<UserWithSpeakingLanguagesViewModel>> GetAllUsersSpeakingLanguages()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithSpeakingLanguagesViewModel>>($"User/GetAllUsersSpeakingLanguages");
            return response;
        }
        public async Task<UserWithSpeakingLanguagesViewModel> GetByIdUserSpeakingLanguages(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithSpeakingLanguagesViewModel>($"User/GetByIdUserSpeakingLanguages?={Id}");
            return response;
        }

        public async Task<ICollection<UserWithUserAdressViewModel>> GetAllUsersWithAdress()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithUserAdressViewModel>>($"User/GetAllUsersWithAdress");
            return response;
        }
        public async Task<UserWithUserAdressViewModel> GetByIdUserWithAdress(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithUserAdressViewModel>($"User/GetByIdUserWithAdress?={Id}");
            return response;
        }

        public async Task<ICollection<UserWithUserInformationViewModel>> GetAllUserWithUserInformation()
        {
            var response = await _httpClient.GetFromJsonAsync<ICollection<UserWithUserInformationViewModel>>($"User/GetAllUserWithUserInformation");
            return response;
        }
        public async Task<UserWithUserInformationViewModel> GetByIdUserWithUserInformation(int Id)
        {
            var response = await _httpClient.GetFromJsonAsync<UserWithUserInformationViewModel>($"User/GetByIdUserWithUserInformation?={Id}");
            return response;
        }



    }
}
