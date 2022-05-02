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
        private readonly CharacterService _characterService;

        public CharactersController(CharacterService characterService)
        {
            _characterService = characterService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_characterService.GetAll());
        }
        

    }
}
