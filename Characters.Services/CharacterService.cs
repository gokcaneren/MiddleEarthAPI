using Characters.Dal.Repository;
using Characters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Services
{
    public class CharacterService:IService
    {
        private readonly CharacterRepository _characterRepository;

        public CharacterService(CharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<IList<Character>> GetAll()
        {
            return await _characterRepository.GetAll();
        }
    }
}
