using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using dnp_assignment_4.Data;
using dnp_assignment_4.Models;
using Microsoft.AspNetCore.Components;

namespace DNP4.Data
{
    public class FilterService : IFilterService
    {
        private HttpClient _httpClient;

        public FilterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IList<Person>> FindPersonByName(string name)
        {
            try
            {
                Task<IList<Person>> personS = _httpClient.GetJsonAsync<IList<Person>>("filter/person/?name=" + name);
                var people = await personS;
                return people;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        public async Task<IList<Person>> GetAllPeople()
        {
            try
            {
                Task<IList<Person>> person = _httpClient.GetJsonAsync<IList<Person>>("/person");
                var people = await person;
                return people;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}