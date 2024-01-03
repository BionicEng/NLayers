using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Services.Concrete
{
    public class UserService : Service<UserEntity> , IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        public UserService(IGenericRepository<UserEntity> repository, IUnitOfWork unitOfWork, IUserRepository userRepository) : base(unitOfWork,repository) 
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<List<UserEntity>> GetAllUserCertificates()
        {
            return await _userRepository.GetAllUserCertificates();
        }

        public async Task<List<UserEntity>> GetAllUserCompanyInfos()
        {
            return await _userRepository.GetAllUserCompanyInfos();
        }

        public async Task<List<UserEntity>> GetAllUserCompanyInfosWithRole()
        {
            return await _userRepository.GetAllUserCompanyInfosWithRole();
        }

        public async Task<List<UserEntity>> GetAllUserKnownPrograms()
        {
            return await _userRepository.GetAllUserKnownPrograms();
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<List<UserEntity>> GetAllUserSchoolInfos()
        {
            return await _userRepository.GetAllUserSchoolInfos();
        }

        public async Task<List<UserEntity>> GetAllUserSchoolInfosWithDepartments()
        {
            return await _userRepository.GetAllUserSchoolInfosWithDepartments();
        }

        public async Task<List<UserEntity>> GetAllUserSpeakingLanguages()
        {
            return await _userRepository.GetAllUserSpeakingLanguages();
        }


        public async Task<List<UserEntity>> GetAllUserWithAdress()
        {
            return await _userRepository.GetAllUserUserAdress();
        }

        public async Task<List<UserEntity>> GetAllUserWithUserInformation()
        {
            return await _userRepository.GetAllUserUserInformation();
        }

        public async Task<UserEntity> GetByIdUser(int Id)
        {
            return await _userRepository.GetByIdUser(Id);
        }

        public async Task<UserEntity> GetByIdUserCertificates(int Id)
        {
            return await _userRepository.GetByIdUserCertificates(Id);
        }

        public async Task<UserEntity> GetByIdUserCompanyInfos(int Id)
        {
            return await _userRepository.GetByIdUserCompanyInfos(Id);
        }

        public async Task<UserEntity> GetByIdUserCompanyInfosWithRole(int Id)
        {
            return await _userRepository.GetByIdUserCompanyInfosWithRole(Id);
        }

        public async Task<UserEntity> GetByIdUserKnownPrograms(int Id)
        {
            return await _userRepository.GetByIdUserKnownPrograms(Id);
        }

        public async Task<UserEntity> GetByIdUserSchoolInfos(int Id)
        {
            return await _userRepository.GetByIdUserSchoolInfos(Id);
        }

        public async Task<UserEntity> GetByIdUserSchoolInfosWithDepartments(int Id)
        {
            return await _userRepository.GetByIdUserSchoolInfosWithDepartments(Id);
        }

        public async Task<UserEntity> GetByIdUserSpeakingLanguages(int Id)
        {
            return await _userRepository.GetByIdUserSpeakingLanguages(Id);
        }

        public async Task<UserEntity> GetByIdUserUserAdress(int Id)
        {
            return await _userRepository.GetByIdUserUserAdress(Id);
        }

        public async Task<UserEntity> GetByIdUserUserInformation(int Id)
        {
            return await _userRepository.GetByIdUserUserInformation(Id);
        }
    }
}
