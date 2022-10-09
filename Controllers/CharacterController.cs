using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace first_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Sam"},
            new Character { Name = "Strider" },
            new Character { Name = "Gandolf", Class = RpgClass.Wizzard },
            new Character { Name =  "Healer", Class = RpgClass.Cleric },
        };

        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
    }
}