using Characters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Services
{
    public class CharacterService
    {
        private List<Character> characters;

        public CharacterService()
        {
            characters = new List<Character>
            {
                new Character{Id=1, Name="Aragorn", Age=75, RaceId=2, isAlive=true, ImageUrl="https://static.wikia.nocookie.net/ortadunya/images/3/34/Aragorn2.jpg/revision/latest?cb=20210609105006"},
                new Character{Id=2, Name="Gandalf", Age=150, RaceId=5, isAlive=true, ImageUrl="https://static.wikia.nocookie.net/lotr/images/e/e7/Gandalf_the_Grey.jpg/revision/latest?cb=20121110131754"},
                new Character{Id=3, Name="Boromir", Age=43, RaceId=2, isAlive=false, ImageUrl="https://static.wikia.nocookie.net/lotr/images/b/b4/Seanbean_boromir.jpg/revision/latest?cb=20110327195115"},
                new Character{Id=4, Name="Legolas", Age=66, RaceId=1, isAlive=true, ImageUrl="https://static.wikia.nocookie.net/middle-earth-film-saga/images/7/77/Legolas.png/revision/latest/top-crop/width/360/height/450?cb=20160207050831"},
                new Character{Id=5, Name="Witch King", Age=135, RaceId=1, isAlive=false, ImageUrl="https://static.wikia.nocookie.net/lotr/images/5/59/Witch-king.jpg/revision/latest?cb=20220209185252"},
                new Character{Id=6, Name="Gimli", Age=63, RaceId=3, isAlive=true, ImageUrl="https://static.wikia.nocookie.net/ortadunya/images/4/43/Gimli.jpg/revision/latest/top-crop/width/360/height/450?cb=20190424060619"}
            };
        }

        public List<Character> GetAll()
        {
            return characters;
        }

    }
}
