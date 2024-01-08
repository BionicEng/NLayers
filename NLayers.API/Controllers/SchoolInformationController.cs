using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayers.Core.DTOs;
using NLayers.Core.Entities;
using NLayers.Core.Services.Abstract;
using NLayers.Services.Exceptions;
using NLayers.Services.Services.Concrete;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace NLayers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolInformationController : ControllerBase
    {
        private readonly ISchoolInformationService _schoolInformationService;
        private readonly IMapper _mapper;
        public SchoolInformationController(ISchoolInformationService schoolInformationService, IMapper mapper)
        {
            _schoolInformationService = schoolInformationService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSchoolInformation()
        {
            var schoolInformations = await _schoolInformationService.GetAllSchoolInformations();
            if (schoolInformations is not null)
            {
                var schoolInformationDTOs = _mapper.Map<List<SchoolInformationDTO>>(schoolInformations.ToList());
                string jsonString = JsonSerializer.Serialize(schoolInformationDTOs);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdSchoolInformation(int Id)
        {
            var schoolInformation = await _schoolInformationService.GetSchoolInformationById(Id);
            if (schoolInformation is not null)
            {
                var schoolInformationDTO = _mapper.Map<SchoolInformationDTO>(schoolInformation);
                string jsonString = JsonSerializer.Serialize(schoolInformationDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSchoolInformationWithDepartment()
        {
            var schoolInformations = await _schoolInformationService.GetAllSchoolInformationsWithDepartments();
            if (schoolInformations is not null)
            {
                var schoolInformationDTOs = _mapper.Map<List<SchoolInformationDTO>>(schoolInformations.ToList());
                string jsonString = JsonSerializer.Serialize(schoolInformationDTOs);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdCSchoolInformationWithDepartment(int Id)
        {
            var schoolInformation = await _schoolInformationService.GetSchoolInformationWithDepartmentsById(Id);
            if (schoolInformation is not null)
            {
                var schoolInformationDTO = _mapper.Map<SchoolInformationDTO>(schoolInformation);
                string jsonString = JsonSerializer.Serialize(schoolInformationDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSchoolInformationWithUser()
        {
            var schoolInformations = await _schoolInformationService.GetAllSchoolInformationsWithUser();
            if (schoolInformations is not null)
            {
                var schoolInformationDTOs = _mapper.Map<List<SchoolInformationDTO>>(schoolInformations.ToList());
                string jsonString = JsonSerializer.Serialize(schoolInformationDTOs);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdCSchoolInformationWithUser(int Id)
        {
            var schoolInformation = await _schoolInformationService.GetSchoolInformationWithUserById(Id);
            if (schoolInformation is not null)
            {
                var schoolInformationDTO = _mapper.Map<SchoolInformationDTO>(schoolInformation);
                string jsonString = JsonSerializer.Serialize(schoolInformationDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        

        [HttpPost("[action]")]
        public async Task<IActionResult> AddSchoolInformation(SchoolInformationAddDTO schoolInformationDTO)
        {
            if (schoolInformationDTO is not null)
            {
                var schoolInformationEntity = _mapper.Map<SchoolInformationEntity>(schoolInformationDTO);
                await _schoolInformationService.AddAsync(schoolInformationEntity);
                return Ok(schoolInformationEntity);

            }
            return NotFound();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSchoolInformation(SchoolInformationAddDTO schoolInformationDTO, int id)
        {
            if (schoolInformationDTO is not null)
            {
                var schoolInformationEntity = _mapper.Map<SchoolInformationEntity>(schoolInformationDTO);
                schoolInformationEntity.Id = id;
                await _schoolInformationService.UpdateAsync(schoolInformationEntity);
                return Ok(schoolInformationEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteSchoolInformation(int id)
        {
            var schoolInformationEntity = await _schoolInformationService.GetSchoolInformationById(id);

            if (schoolInformationEntity is not null)
            {
                await _schoolInformationService.DeleteAsync(schoolInformationEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}
