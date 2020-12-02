using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IFilterService
    {
        Task<IList<Person>> GetAllPeople();
        Task<IList<Person>> FindPersonByName(string name);
    }
}