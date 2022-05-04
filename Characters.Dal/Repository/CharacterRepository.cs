using Characters.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Dal.Repository
{
    public class CharacterRepository:ICharacterRepository
    {
        private readonly ApplicationDbContext _context;


        public CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IList<Character>> GetAll()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character> GetById(int id)
        {
            return await _context.Characters.FindAsync(id);
        }

        public async Task<IEnumerable<Character>> GetByName(string name)
        {
            return await _context.Characters.Where(x => x.Name.Contains(name)).ToListAsync();
        }
    }
}
