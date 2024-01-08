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
    public class SpeakingLanguageController : ControllerBase
    {
        private readonly ISpeakingLanguageService _speakingLanguageService;
        private readonly IMapper _mapper;
        public SpeakingLanguageController(ISpeakingLanguageService speakingLanguageService, IMapper mapper)
        {
            _speakingLanguageService = speakingLanguageService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSpeakingLanguage()
        {
            var speakingLanguages = await _speakingLanguageService.GetAllSpeakingLanguages();
            if (speakingLanguages is not null)
            {
                var speakingLanguagesDTO = _mapper.Map<List<SpeakingLanguageDTO>>(speakingLanguages.ToList());
                string jsonString = JsonSerializer.Serialize(speakingLanguagesDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdSpeakingLanguage(int Id)
        {
            var speakingLanguage = await _speakingLanguageService.GetByIdSpeakingLanguage(Id);
            if (speakingLanguage is not null)
            {
                var speakingLanguageDTO = _mapper.Map<SpeakingLanguageDTO>(speakingLanguage);
                string jsonString = JsonSerializer.Serialize(speakingLanguageDTO);
                return Ok(jsonString);
            }
            return NotFound();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddSpeakingLanguage(SpeakingLanguageAddDTO speakingLanguage)
        {
            if (speakingLanguage is not null)
            {
                var speakingLanguageEntity = _mapper.Map<SpeakingLanguageEntity>(speakingLanguage);
                await _speakingLanguageService.AddAsync(speakingLanguageEntity);
                return Ok(speakingLanguageEntity);

            }
            return NotFound();


        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateSpeakingLanguage(SpeakingLanguageAddDTO speakingLanguage, int id)
        {
            if (speakingLanguage is not null)
            {
                var speakingLanguageEntity = _mapper.Map<SpeakingLanguageEntity>(speakingLanguage);
                speakingLanguageEntity.Id = id;
                await _speakingLanguageService.UpdateAsync(speakingLanguageEntity);
                return Ok(speakingLanguageEntity);
            }
            return NotFound();
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteSpeakingLanguage(int id)
        {
            var speakingLanguageEntity = await _speakingLanguageService.GetByIdSpeakingLanguage(id);

            if (speakingLanguageEntity is not null)
            {
                await _speakingLanguageService.DeleteAsync(speakingLanguageEntity);
                return Ok();
            }
            return NotFound();
        }
    }
}