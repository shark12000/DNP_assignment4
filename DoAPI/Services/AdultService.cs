using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;

namespace DoAPI.Services
{
    public class AdultService : IAdultService
    {
        private readonly MyDbContext _myDbContext;

        public AdultService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IList<Adult>> GetAsync(int familyId)
        {
            try
            {
                IList<Adult> adults = new List<Adult>(_myDbContext.Adults.Where(f => f.FamilyId == familyId));
                return adults;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Adult>();
            }
        }
        
        public async Task<IList<Adult>> GetAllAdultsAsync()
        {
            try
            {
                IList<Adult> adults = new List<Adult>(_myDbContext.Adults);
                return adults;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Adult>();
            }
        }

        public async Task<Adult> AddAsync(Adult adult)
        {
            try
            {
                await _myDbContext.Adults.AddAsync(adult);
                await _myDbContext.SaveChangesAsync();
                return adult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<Adult> Update(Adult adult)
        {
            try
            { 
                Console.WriteLine(adult.AdultId);
                Console.WriteLine(adult.FirstName);
                Adult myAdult = _myDbContext.Adults.FirstOrDefault(f => f.AdultId == adult.AdultId);
                if (myAdult == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    myAdult.Update(adult);
                    _myDbContext.Update(myAdult);
                }
                await _myDbContext.SaveChangesAsync();
                return myAdult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            Console.WriteLine(id);
            Adult adult = _myDbContext.Adults.FirstOrDefault(f => f.AdultId == id);
            if (adult == null)
            {
                Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Adults.Remove(adult);
            }

            await _myDbContext.SaveChangesAsync();
        }

        public async Task<Adult> GetAdult(int adultId)
        {
            Adult first = _myDbContext.Adults.FirstOrDefault(a => a.AdultId == adultId);
            if (first == null)
            {
                Console.WriteLine("I am null");
            }
            
            return first;
        }
    }
}