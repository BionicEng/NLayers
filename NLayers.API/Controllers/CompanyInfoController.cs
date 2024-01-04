using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayers.Core.DTOs;
using NLayers.Core.Entities;
using NLayers.Core.Services.Abstract;
using System.Text.Json;

namespace NLayers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : ControllerBase
    {
        private readonly ICompanyInfoService _companyInfoService;
        private readonly IMapper _mapper;
        public CompanyInfoController(ICompanyInfoService companyInfoService, IMapper mapper)
        {
            _companyInfoService = companyInfoService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompanyInfo()
        {
            var companyInfos = await _companyInfoService.GetAllCompanyInfoAsync();
            if (companyInfos is not null)
            {
                var companyInfoDTOs = _mapper.Map<List<CompanyInfoDTO>>(companyInfos.ToList());
                string jsonString = JsonSerializer.Serialize(companyInfoDTOs);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdCompanyInfo(int Id)
        {
            var companyInfo = await _companyInfoService.GetByIdCompanyInfoAsync(Id);
            if (companyInfo is not null)
            {
                var companyInfoDTO = _mapper.Map<CompanyInfoDTO>(companyInfo);
                string jsonString = JsonSerializer.Serialize(companyInfoDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddCompanyInfo(CompanyInfoAddDTO companyInfo)
        {
            if (companyInfo is not null)
            {
                var companyInfoEntity = _mapper.Map<CompanyInfoEntity>(companyInfo);
                await _companyInfoService.AddAsync(companyInfoEntity);
                return Ok(companyInfoEntity);

            }
            return NotFound();

        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCompanyInfo(CompanyInfoAddDTO companyInfo, int id)
        {
            if (companyInfo is not null)
            {
                var companyInfoEntity = _mapper.Map<CompanyInfoEntity>(companyInfo);
                companyInfoEntity.Id = id;
                await _companyInfoService.UpdateAsync(companyInfoEntity);
                return Ok(companyInfoEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCompanyInfo(int id)
        {
            var companyInfoEntity = await _companyInfoService.GetByIdAsync(id);

            if (companyInfoEntity is not null)
            {
                await _companyInfoService.DeleteAsync(companyInfoEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}

