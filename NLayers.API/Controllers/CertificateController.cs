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
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateService _certificateService;
        private readonly IMapper _mapper;
        public CertificateController(ICertificateService certificateService, IMapper mapper)
        {
            _certificateService = certificateService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCertificates()
        {
            var certificates = await _certificateService.GetAllCertificates();
            if (certificates is not null)
            {
                var certificateDTO = _mapper.Map<List<CertificateDTO>>(certificates.ToList());
                string jsonString = JsonSerializer.Serialize(certificateDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdCertificate(int Id)
        {
            var certificates = await _certificateService.GetByIdCertificate(Id);
            if (certificates is not null)
            {
                var certificateDTO = _mapper.Map<CertificateDTO>(certificates);
                string jsonString = JsonSerializer.Serialize(certificateDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddCertificate(CertificateAddDTO certificate)
        {
            if (certificate is not null)
            {
                var certificateEntity = _mapper.Map<CertificateEntity>(certificate);
                await _certificateService.AddAsync(certificateEntity);
                return Ok(certificateEntity);

            }
            return NotFound();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCertificate(CertificateAddDTO certificate,int id)
        {
            if (certificate is not null)
            {
                var certificateEntity = _mapper.Map<CertificateEntity>(certificate);
                certificateEntity.Id = id;
                await _certificateService.UpdateAsync(certificateEntity);
                return Ok(certificateEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCertificate(int id)
        {
            var certificateEntity = await _certificateService.GetByIdCertificate(id);

            if (certificateEntity is not null)
            {
                await _certificateService.DeleteAsync(certificateEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}
