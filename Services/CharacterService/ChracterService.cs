using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_project.Services.CharacterService
{
    public class ChracterService : ICharacterService
    {

        private static Character defaultCharacter = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Id = 1, Name = "Sam"},
            new Character { Id = 2, Name = "Strider" },
            new Character { Id = 3, Name = "Gandolf", Class = RpgClass.Wizzard },
            new Character { Id = 4, Name =  "Healer", Class = RpgClass.Cleric },
            new Character { Id = 5, Name = "Gemli", Class = RpgClass.Knight },
        };

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id) => characters.FirstOrDefault(character => character.Id == id);


        public Character GetDefaultCharacter()
        {
            return defaultCharacter;
        }
    }
}