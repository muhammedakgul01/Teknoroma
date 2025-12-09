using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        
    }
}