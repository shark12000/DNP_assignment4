using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace DNP4.Data
{
    public interface IFilterService
    {
        Task<IList<Person>> FindPersonByName(string name);
        Task<IList<Person>> GetAllPeople();
    }
}