using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace dnp_assignment_4.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetFamilyAdults(int familyId);
        Task<IList<Adult>> GetAdultsByFamily(int familyId);
        Task<Adult> GetAdult(int adultId);
        Task<string> CreateAdult(Adult adult);
        Task<string> Update(Adult adult);
        Task<string> RemoveAdult(int adultId);
    }
}