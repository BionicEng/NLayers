using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayers.Core.DTOs;
using NLayers.Core.Entities;
using NLayers.Core.Services.Abstract;
using System.Text.Json;

namespace NLayers.API.Controllers
{
    public class CompanyUserRoleController : Controller
    {
        private readonly ICompanyUserRoleService _companyUserRoleService;
        private readonly IMapper _mapper;
        public CompanyUserRoleController(ICompanyUserRoleService companyUserRoleService, IMapper mapper)
        {
            _companyUserRoleService = companyUserRoleService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompanyUserRole()
        {
            var companyUserRoles = await _companyUserRoleService.GetAllCompanyUserRoleAsync();
            if (companyUserRoles is not null)
            {
                var companyUserRoleDTOs = _mapper.Map<List<CompanyUserRoleDTO>>(companyUserRoles.ToList());
                string jsonString = JsonSerializer.Serialize(companyUserRoleDTOs);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdCompanyUserRole(int Id)
        {
            var companyUserRole = await _companyUserRoleService.GetByIdCompanyUserRoleAsync(Id);
            if (companyUserRole is not null)
            {
                var companyUserRoleDTO = _mapper.Map<CompanyUserRoleDTO>(companyUserRole);
                string jsonString = JsonSerializer.Serialize(companyUserRoleDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddCompanyUserRole(CompanyUserRoleDTO companyUserRole)
        {
            if (companyUserRole is not null)
            {
                var companyUserRoleEntity = _mapper.Map<CompanyUserRoleEntity>(companyUserRole);
                await _companyUserRoleService.AddAsync(companyUserRoleEntity);
                return Ok(companyUserRoleEntity);

            }
            return NotFound();

        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCompanyUserRole(CompanyUserRoleDTO companyUserRole, int id)
        {
            if (companyUserRole is not null)
            {
                var companyUserRoleEntity = _mapper.Map<CompanyUserRoleEntity>(companyUserRole);
                companyUserRoleEntity.Id = id;
                await _companyUserRoleService.UpdateAsync(companyUserRoleEntity);
                return Ok(companyUserRoleEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCompanyUserRole(int id)
        {
            var companyUserRoleEntity = await _companyUserRoleService.GetByIdAsync(id);

            if (companyUserRoleEntity is not null)
            {
                await _companyUserRoleService.DeleteAsync(companyUserRoleEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}
