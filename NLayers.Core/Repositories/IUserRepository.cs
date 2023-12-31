﻿using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        Task<List<UserEntity>> GetAllUsers();
        Task<UserEntity> GetByIdUser(int Id);
        Task<List<UserEntity>> GetAllUserCertificates();
        Task <UserEntity> GetByIdUserCertificates(int Id);


        Task<List<UserEntity>> GetAllUserKnownPrograms();
        Task<UserEntity> GetByIdUserKnownPrograms(int Id);


        Task<List<UserEntity>> GetAllUserSpeakingLanguages();
        Task<UserEntity> GetByIdUserSpeakingLanguages(int Id);

        Task<List<UserEntity>> GetAllUserUserAdress();
        Task<UserEntity> GetByIdUserUserAdress(int Id);
        Task<UserEntity> GetByIdUserUserInformation(int Id);
        Task<List<UserEntity>> GetAllUserUserInformation();


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
