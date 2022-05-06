using Characters.DTO.Requests;
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

        [HttpPost]
        public async Task<IActionResult> Add(AddCharacterRequest request)
        {
            if (ModelState.IsValid)
            {
                int characterId = await _characterService.AddCharacter(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = characterId }, value: null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCharacterRequest request)
        {
            if (await _characterService.IsCharacterExist(id))
            {
                if (ModelState.IsValid)
                {
                    await _characterService.UpdateCharacter(request);
                    return Ok();
                }
                return BadRequest(ModelState);
            }
            return NotFound(new { message = $"Charcter with id:{id} not found" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _characterService.IsCharacterExist(id))
            {
                await _characterService.DeleteCharacter(id);
                return Ok();
            }
            return NotFound(new { message = $"Charcter with id:{id} not found" });
        }
    }
}
