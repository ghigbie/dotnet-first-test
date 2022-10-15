using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_project.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;


namespace first_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {

        private static Character defaultCharacter = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Sam"},
            new Character { Id = 2, Name = "Strider" },
            new Character { Id = 3, Name = "Gandolf", Class = RpgClass.Wizzard },
            new Character { Id = 4, Name = "Healer", Class = RpgClass.Cleric },
            new Character { Id = 5, Name = "Gemli", Class = RpgClass.Knight },
        };

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]

        public ActionResult<Character> Get(int id)
        {
            if(id < characters.Count)
            {
                return Ok(_characterService.GetCharacterById(id));
            }
            else
            {
                return Ok("No characters exists with this Id");
            }
        }

        [HttpGet("GetDefault")]
        public ActionResult<Character> GetDefault()
        {
            return Ok(_characterService.GetDefaultCharacter());
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {

            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}