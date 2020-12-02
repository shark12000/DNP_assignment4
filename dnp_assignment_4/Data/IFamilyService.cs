using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace dnp_assignment_4.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetAllFamilies();
        Task<IList<Family>> GetCurrentUserFamilies(int id);
        Task<string> Update(Family family);
        Task<string> CreateFamily(Family family);
        Task<string> RemoveFamily(int familyId);
        Task<Family> GetFamily(int familyId);
    }
}