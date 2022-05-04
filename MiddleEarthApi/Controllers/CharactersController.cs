using Characters.DTO.Responses;
using Characters.Entities;
using Characters.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiddleEarthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly IService _characterService;

        public CharactersController(IService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _characterService.GetAll());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            CharactersRespons character = await _characterService.GetById(id);
            return Ok(character);
        }

        [HttpGet("Find/{name}")]
        public async Task<IActionResult> Find(string name)
        {
            var characters = await _characterService.GetByName(name);
            return Ok(characters);
        }
    }
}
