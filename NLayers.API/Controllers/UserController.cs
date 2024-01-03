using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayers.Core.DTOs;
using NLayers.Core.Entities;
using NLayers.Core.Services.Abstract;
using NLayers.Services.Services.Concrete;
using System.Text.Json;

namespace NLayers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            if (users is not null)
            {
                var userDTO = _mapper.Map<List<UserDTO>>(users.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUser(int Id)
        {
            var user = await _userService.GetByIdUser(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithCertificates()
        {
            var usersWithCertificates = await _userService.GetAllUserCertificates();
            if (usersWithCertificates is not null)
            {
                var userDTO = _mapper.Map<List<UserWithCertificateDTO>>(usersWithCertificates.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithCertificates(int Id)
        {
            var user = await _userService.GetByIdUserCertificates(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithCertificateDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithCompanyInfos()
        {
            var usersCompanyInfos = await _userService.GetAllUserCompanyInfos();
            if (usersCompanyInfos is not null)
            {
                var userDTO = _mapper.Map<List<UserWithCompanyInfoDTO>>(usersCompanyInfos.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithCompanyInfos(int Id)
        {
            var user = await _userService.GetByIdUserCompanyInfos(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithCompanyInfoDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithCompanyInfosWithRole()
        {
            var usersCompanyInfosWithRole = await _userService.GetAllUserCompanyInfosWithRole();
            if (usersCompanyInfosWithRole is not null)
            {
                var userDTO = _mapper.Map<List<UserWithCompanyInfoDTO>>(usersCompanyInfosWithRole.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithCompanyInfosWithRole(int Id)
        {
            var user = await _userService.GetByIdUserCompanyInfosWithRole(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithCompanyInfoDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithKnownPrograms()
        {
            var usersWithKnownPrograms = await _userService.GetAllUserKnownPrograms();
            if (usersWithKnownPrograms is not null)
            {
                var userDTO = _mapper.Map<List<UserWithKnownProgramsDTO>>(usersWithKnownPrograms.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithKnownPrograms(int Id)
        {
            var user = await _userService.GetByIdUserKnownPrograms(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithKnownProgramsDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithSchoolInfos()
        {
            var usersWithSchoolInfos = await _userService.GetAllUserSchoolInfos();
            if (usersWithSchoolInfos is not null)
            {
                var userDTO = _mapper.Map<List<UserWithSchoolInfosDTO>>(usersWithSchoolInfos.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithSchoolInfos(int Id)
        {
            var user = await _userService.GetByIdUserSchoolInfos(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithSchoolInfosDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithSchoolInfosWithDepartments()
        {
            var usersWithSchoolInfosWithDepartments = await _userService.GetAllUserSchoolInfosWithDepartments();
            if (usersWithSchoolInfosWithDepartments is not null)
            {
                var userDTO = _mapper.Map<List<UserWithSchoolInfosDTO>>(usersWithSchoolInfosWithDepartments.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithSchoolInfosWithDepartments(int Id)
        {
            var user = await _userService.GetByIdUserSchoolInfosWithDepartments(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithSchoolInfosDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersSpeakingLanguages()
        {
            var usersSpeakingLanguages = await _userService.GetAllUserSpeakingLanguages();
            if (usersSpeakingLanguages is not null)
            {
                var userDTO = _mapper.Map<List<UserWithSpeakingLanguagesDTO>>(usersSpeakingLanguages.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserSpeakingLanguages(int Id)
        {
            var user = await _userService.GetByIdUserSpeakingLanguages(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithSpeakingLanguagesDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithAdress()
        {
            var userWithAdress = await _userService.GetAllUserWithAdress();
            if (userWithAdress is not null)
            {
                var userDTO = _mapper.Map<List<UserWithAdressDTO>>(userWithAdress.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithAdress(int Id)
        {
            var user = await _userService.GetByIdUserUserAdress(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithAdressDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsersWithUserİnformationDTO()
        {
            var usersWithUserDTO = await _userService.GetAllUserWithUserInformation();
            if (usersWithUserDTO is not null)
            {
                var userDTO = _mapper.Map<List<UserWithUserInformationDTO>>(usersWithUserDTO.ToList());
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdUserWithUserInfo(int Id)
        {
            var user = await _userService.GetByIdUserUserInformation(Id);
            if (user is not null)
            {
                var userDTO = _mapper.Map<UserWithUserInformationDTO>(user);
                string jsonString = JsonSerializer.Serialize(userDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddUser(RegisterDTO user)
        {
            if (user is not null)
            {
                var userEntity = _mapper.Map<UserEntity>(user);
                await _userService.AddAsync(userEntity);
                return Ok(userEntity);

            }
            return BadRequest();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateUser(UserDTO user)
        {
            if (user is not null)
            {
                var userEntity = _mapper.Map<UserEntity>(user);
                await _userService.UpdateAsync(userEntity);
                return Ok(userEntity);
            }
            return BadRequest();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _userService.GetByIdAsync(id);

            if (user is not null)
            {
                await _userService.DeleteAsync(user);
                return Ok();
            }
            return BadRequest();
        }

    }
}
