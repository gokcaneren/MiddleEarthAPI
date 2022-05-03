using AutoMapper;
using Characters.Dal.Repository;
using Characters.DTO.Responses;
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
        private readonly IMapper mapper;
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository, IMapper mapper)
        {
            this.mapper = mapper;
            _characterRepository = characterRepository;
        }

        public async Task<IList<CharactersRespons>> GetAll()
        {
            var characters = await _characterRepository.GetAll();
            var result = mapper.Map<IList<CharactersRespons>>(characters);
            return result;
        }
    }
}
