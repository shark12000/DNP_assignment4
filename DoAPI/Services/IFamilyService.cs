using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IFamilyService
    {
        Task<List<Family>> GetAsync();
        Task<IList<Family>> GetAsync(int id);
        Task<Family> GetFamily(int id);
        Task<Family> AddAsync(Family family);
        Task<Family> Update(Family family);
        Task DeleteAsync(int id);
    }
}