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
    public class SchoolDepartmentController : ControllerBase
    {
        private readonly ISchoolDepartmentService _schoolDepartmentService;
        private readonly IMapper _mapper;
        public SchoolDepartmentController(ISchoolDepartmentService schoolDepartmentService, IMapper mapper)
        {
            _schoolDepartmentService = schoolDepartmentService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSchoolDepartment() 
        {
            var schoolDepartments = await _schoolDepartmentService.GetAllSchoolDepartmentAsync();        
            if (schoolDepartments is not null) 
            {
                var schoolDepartmentDTOs = _mapper.Map<List<SchoolDepartmentDTO>>(schoolDepartments);
                string jSonString = JsonSerializer.Serialize(schoolDepartmentDTOs);
                return Ok(jSonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdSchoolDepartment(int Id)
        {
            var schoolDepartment = await _schoolDepartmentService.GetByIdSchoolDepartmentAsync(Id);
            if (schoolDepartment is not null)
            {
                var schoolDepartmentDTO = _mapper.Map<SchoolDepartmentDTO>(schoolDepartment);
                string jsonString = JsonSerializer.Serialize(schoolDepartmentDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddSchoolDepartment(SchoolDepartmentAddDTO schoolDepartment)
        {
            if (schoolDepartment is not null)
            {
                var schoolDepartmentEntity = _mapper.Map<SchoolDepartmentEntity>(schoolDepartment);
                await _schoolDepartmentService.AddAsync(schoolDepartmentEntity);
                return Ok(schoolDepartmentEntity);

            }
            return NotFound();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSchoolDepartment(SchoolDepartmentAddDTO schoolDepartment, int id)
        {
            if (schoolDepartment is not null)
            {
                var schoolDepartmentEntity = _mapper.Map<SchoolDepartmentEntity>(schoolDepartment);
                schoolDepartmentEntity.Id = id;
                await _schoolDepartmentService.UpdateAsync(schoolDepartmentEntity);
                return Ok(schoolDepartmentEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteSchoolDepartment(int id)
        {
            var schoolDepartmentEntity = await _schoolDepartmentService.GetByIdSchoolDepartmentAsync(id);

            if (schoolDepartmentEntity is not null)
            {
                await _schoolDepartmentService.DeleteAsync(schoolDepartmentEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}
