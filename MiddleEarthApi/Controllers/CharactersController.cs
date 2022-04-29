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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var characters = new CharacterService().GetAll();
            return Ok(characters);
        }


    }
}
