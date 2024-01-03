using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Services.Abstract
{
    public interface IUserService : IService<UserEntity>
    {
        Task<List<UserEntity>> GetAllUsers();
        Task<UserEntity> GetByIdUser(int Id);
        Task<List<UserEntity>> GetAllUserCertificates();
        Task<UserEntity> GetByIdUserCertificates(int Id);


        Task<List<UserEntity>> GetAllUserKnownPrograms();
        Task<UserEntity> GetByIdUserKnownPrograms(int Id);


        Task<List<UserEntity>> GetAllUserSpeakingLanguages();
        Task<UserEntity> GetByIdUserSpeakingLanguages(int Id);

        Task<UserEntity> GetByIdUserUserAdress(int Id);
        Task<UserEntity> GetByIdUserUserInformation(int Id);

        Task<List<UserEntity>> GetAllUserWithAdress();
        Task<List<UserEntity>> GetAllUserWithUserInformation();

        Task<List<UserEntity>> GetAllUserCompanyInfos();
        Task<UserEntity> GetByIdUserCompanyInfos(int Id);
        Task<List<UserEntity>> GetAllUserCompanyInfosWithRole();
        Task<UserEntity> GetByIdUserCompanyInfosWithRole(int Id);

        Task<List<UserEntity>> GetAllUserSchoolInfos();
        Task<UserEntity> GetByIdUserSchoolInfos(int Id);
        Task<List<UserEntity>> GetAllUserSchoolInfosWithDepartments();
        Task<UserEntity> GetByIdUserSchoolInfosWithDepartments(int Id);
    }
}
