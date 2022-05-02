using Characters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Services
{
    public interface IService
    {
         public Task<List<Character>> GetAll();
    }
}
