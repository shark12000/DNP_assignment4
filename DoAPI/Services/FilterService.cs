using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;

namespace DoAPI.Services
{
    public class FilterService : IFilterService
    {
        private readonly MyDbContext _myDbContext;

        public FilterService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IList<Person>> GetAllPeople()
        {
           
            List<Person> children = new List<Person>(_myDbContext.Children);
            List<Person> adults = new List<Person>(_myDbContext.Adults);
            List<Person> people = new List<Person>();
            
            people.AddRange(children);
            people.AddRange(adults);
            
            
            if (people.Equals(null))
            {
                return new List<Person>();
            }
            
            return people;
        }

        public async Task<IList<Person>> FindPersonByName(string name)
        {
            List<Person> children = new List<Person>(_myDbContext.Children);
            List<Person> adults = new List<Person>(_myDbContext.Adults);
            List<Person> people = new List<Person>();
            
            people.AddRange(children.Where(a => $"{a.FirstName} {a.LastName}".Contains(name) || $"{a.LastName} {a.FirstName}".Contains(name)).ToList());
            people.AddRange(adults.Where(a => $"{a.FirstName} {a.LastName}".Contains(name) || $"{a.LastName} {a.FirstName}".Contains(name)).ToList());
            
            
            if (people.Equals(null))
            {
                return new List<Person>();
            }

            return people;
        }
    }
}