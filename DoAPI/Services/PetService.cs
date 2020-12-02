using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;

namespace DoAPI.Services
{
    public class PetService : IPetService
    {
        private readonly MyDbContext _myDbContext;

        public PetService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

         public async Task<IList<Pet>> GetAsync(int familyId)
        {
            try
            {
                IList<Pet> pets = new List<Pet>(_myDbContext.Pets.Where(f => f.FamilyId == familyId));
                return pets;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Pet>();
            }
        }
        
        public async Task<IList<Pet>> GetAllPetsAsync()
        {
            try
            {
                IList<Pet> pets = new List<Pet>(_myDbContext.Pets);
                return pets;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Pet>();
            }
        }

        public async Task<Pet> AddAsync(Pet pet)
        {
            try
            {
                await _myDbContext.Pets.AddAsync(pet);
                await _myDbContext.SaveChangesAsync();
                return pet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<Pet> Update(Pet pet)
        {
            try
            {
                Pet myPet = _myDbContext.Pets.FirstOrDefault(f => f.PetId == pet.PetId);
                if (myPet == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    myPet.Update(pet);
                    _myDbContext.Update(myPet);
                }
                await _myDbContext.SaveChangesAsync();
                return myPet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            Pet pet = _myDbContext.Pets.FirstOrDefault(f => f.PetId == id);
            if (pet == null)
            {
                Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Pets.Remove(pet);
            }

            await _myDbContext.SaveChangesAsync();
        }

        public async Task<Pet> GetPet(int petId)
        {
            Pet first = _myDbContext.Pets.FirstOrDefault(a => a.PetId == petId);
            if (first == null)
            {
                Console.WriteLine("I am null");
            }
            
            return first;
        }
    }
}