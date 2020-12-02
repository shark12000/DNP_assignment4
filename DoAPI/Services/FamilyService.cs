using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAPI.Services
{
    public class FamilyService : IFamilyService
    {
        private readonly MyDbContext _myDbContext;

        public FamilyService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<List<Family>> GetAsync()
        {
            if (_myDbContext.Families.Equals(null))
            {
                return new List<Family>();
            }
            return new List<Family>(_myDbContext.Families);
        }
        
        public async Task<Family> AddAsync(Family family)
        {
            try
            {
                await _myDbContext.Families.AddAsync(family);
                await _myDbContext.SaveChangesAsync();
                return family;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<IList<Family>> GetAsync(int id)
        {
            try
            {
                IList<Family> families = _myDbContext.Families.Where(f => f.UserId == id).ToList();
                Console.WriteLine(families);
                return families;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Family>();
            }
        }

        public async Task<Family> Update(Family family)
        {
            try
            { 
                Console.WriteLine(family.Id);
                Console.WriteLine(family.StreetName);
                Family myFamily = _myDbContext.Families.FirstOrDefault(f => f.Id == family.Id);
                if (myFamily == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    myFamily.UpdateFamily(family);
                    Console.WriteLine(myFamily.StreetName);
                    _myDbContext.Update(myFamily);
                }
                await _myDbContext.SaveChangesAsync();
                return myFamily;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task DeleteAsync(int id)
        {
            Console.WriteLine(id);
            Family family = _myDbContext.Families.FirstOrDefault(f => f.Id == id);
            if (family.Equals(null))
            {
             Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Families.Remove(family);
            }

            await _myDbContext.SaveChangesAsync();
        }

        public async Task<Family> GetFamily(int id)
        {
            Console.WriteLine(id);
            Family first = _myDbContext.Families.FirstOrDefault(f => f.Id == id);
            Console.WriteLine(first);
            if (first == null)
            {
                Console.WriteLine("I am null");
            }

            return first;
        }
    }
}
