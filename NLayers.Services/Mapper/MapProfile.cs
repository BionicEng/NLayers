using AutoMapper;
using NLayers.Core.DTOs;
using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CertificateDTO,CertificateEntity>().ReverseMap();
            CreateMap<CompanyInfoDTO, CompanyInfoEntity>().ReverseMap();
            CreateMap<CompanyInfoAddDTO, CompanyInfoEntity>().ReverseMap();
            CreateMap<CompanyUserRoleDTO, CompanyUserRoleEntity>().ReverseMap();
            CreateMap<KnownProgramDTO, KnownProgramEntity>().ReverseMap();
            CreateMap<SchoolDepartmentDTO, SchoolDepartmentEntity>().ReverseMap();
            CreateMap<SchoolInformationDTO, SchoolInformationEntity>().ReverseMap();
            CreateMap<SpeakingLanguageDTO, SpeakingLanguageEntity>().ReverseMap();
            CreateMap<UserAdressDTO, UserAdressEntity>().ReverseMap();
            CreateMap<UserDTO, UserEntity>().ReverseMap();
            CreateMap<UserInformationDTO, UserInformationEntity>().ReverseMap();


            CreateMap<UserWithCertificateDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithCompanyInfoDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithKnownProgramsDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithSchoolInfosDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithSpeakingLanguagesDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithAdressDTO, UserEntity>().ReverseMap();
            CreateMap<UserWithUserInformationDTO, UserEntity>().ReverseMap();
            CreateMap<RegisterDTO, UserEntity>().ReverseMap();


        }
    }
}
