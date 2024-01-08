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
    public class KnownProgramController : ControllerBase
    {
        private readonly IKnownProgramService _knownProgramService;
        private readonly IMapper _mapper;
        public KnownProgramController(IKnownProgramService knownProgramService, IMapper mapper)
        {
            _knownProgramService = knownProgramService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllKnownProgram()
        {
            var knownPrograms = await _knownProgramService.GetAllKnownPrograms();
            if (knownPrograms is not null)
            {
                var knownProgramsDTO = _mapper.Map<List<KnownProgramDTO>>(knownPrograms.ToList());
                string jsonString = JsonSerializer.Serialize(knownProgramsDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdKnownProgram(int Id)
        {
            var knownProgram = await _knownProgramService.GetByIdKnownProgram(Id);
            if (knownProgram is not null)
            {
                var knownProgramDTO = _mapper.Map<KnownProgramDTO>(knownProgram);
                string jsonString = JsonSerializer.Serialize(knownProgramDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddKnownProgram(KnownProgramAddDTO knownProgram)
        {
            if (knownProgram is not null)
            {
                var knownProgramEntity = _mapper.Map<KnownProgramEntity>(knownProgram);
                await _knownProgramService.AddAsync(knownProgramEntity);
                return Ok(knownProgramEntity);

            }
            return NotFound();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateKnownProgram(KnownProgramAddDTO knownProgram, int id)
        {
            if (knownProgram is not null)
            {
                var knownProgramEntity = _mapper.Map<KnownProgramEntity>(knownProgram);
                knownProgramEntity.Id = id;
                await _knownProgramService.UpdateAsync(knownProgramEntity);
                return Ok(knownProgramEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteKnownProgram(int id)
        {
            var knownProgramEntity = await _knownProgramService.GetByIdKnownProgram(id);

            if (knownProgramEntity is not null)
            {
                await _knownProgramService.DeleteAsync(knownProgramEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}
