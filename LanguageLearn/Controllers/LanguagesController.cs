using LanguageLearn.Entities;
using LanguageLearn.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguageLearn.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguagesController(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var languages = await _languageRepository.GetAllAsync();

            return Ok(languages);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var language = await _languageRepository.GetByIdAsync(id);
            if (language == null)
            {
                return NotFound();
            }

            return Ok(language);
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _languageRepository.CreateAsync(language);

            return Ok();
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody]Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _languageRepository.UpdateAsync(language);

            return Ok();
        }

        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromBody] Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _languageRepository.DeleteAsync(language);

            return Ok();
        }
    }
}
