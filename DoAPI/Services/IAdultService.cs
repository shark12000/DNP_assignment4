using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAsync(int familyId);
        Task<Adult> GetAdult(int adultId);
        Task<IList<Adult>> GetAllAdultsAsync();
        Task<Adult> AddAsync(Adult adult);
        Task<Adult> Update(Adult adult);
        Task DeleteAsync(int id);
    }
}