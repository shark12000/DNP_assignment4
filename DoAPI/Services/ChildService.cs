using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;

namespace DoAPI.Services
{
    public class ChildService : IChildService
    {
        private readonly MyDbContext _myDbContext;

        public ChildService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IList<Child>> GetAsync(int familyId)
        {
            try
            {
                IList<Child> children = new List<Child>(_myDbContext.Children.Where(f => f.FamilyId == familyId));
                return children;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Child>();
            }
        }
        
        public async Task<IList<Child>> GetAllChildrenAsync()
        {
            try
            {
                IList<Child> adults = new List<Child>(_myDbContext.Children);
                return adults;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Child>();
            }
        }

        public async Task<IList<Hobby>> GetAllHobbiesAsync()
        {
            try
            {
                IList<Hobby> hobbies = new List<Hobby>(_myDbContext.Hobby);
                return hobbies;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Hobby>();
            }
        }

        public async Task<Child> AddAsync(Child child)
        {
            try
            {
                await _myDbContext.Children.AddAsync(child);
                await _myDbContext.SaveChangesAsync();
                return child;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<Child> Update(Child child)
        {
            try
            {
                Child myChild = _myDbContext.Children.FirstOrDefault(f => f.ChildId == child.ChildId);
                if (myChild == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    myChild.Update(child);
                    _myDbContext.Update(myChild);
                }
                await _myDbContext.SaveChangesAsync();
                return myChild;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            Child child = _myDbContext.Children.FirstOrDefault(f => f.ChildId == id);
            IList<Hobby> hobbiesToRemove = new List<Hobby>(_myDbContext.Hobby.Where(f => f.ChildId == id));
            IList<Pet> petsToRemove = new List<Pet>(_myDbContext.Pets.Where(f => f.ChildId == id));
            if (child == null || hobbiesToRemove.Equals(null) || petsToRemove.Equals(null))
            {
                Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Hobby.RemoveRange(hobbiesToRemove);
                _myDbContext.Pets.RemoveRange(petsToRemove);
                _myDbContext.Children.Remove(child);
            }

            await _myDbContext.SaveChangesAsync();
        }

        public async Task<Child> GetChild(int childId)
        {
            Child first = _myDbContext.Children.FirstOrDefault(a => a.ChildId == childId);
            if (first == null)
            {
                Console.WriteLine("I am null");
            }
            
            return first;
        }

        public async Task<IList<Hobby>> GetChildHobbies(int childId)
        {
            try
            {
                IList<Hobby> hobbys = new List<Hobby>(_myDbContext.Hobby.Where(h => h.ChildId == childId));
                return hobbys;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Hobby>();
            }
        }
        
        public async Task<IList<Pet>> GetChildPets(int childId)
        {
            try
            {
                IList<Pet> pets = new List<Pet>(_myDbContext.Pets.Where(h => h.ChildId == childId));
                return pets;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Pet>();
            }
        }

        public async Task<Hobby> AddHobby(Hobby hobby)
        {
            try
            {
                await _myDbContext.Hobby.AddAsync(hobby);
                await _myDbContext.SaveChangesAsync();
                return hobby;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Pet> AddPet(Pet pet)
        {
            try
            {
                await _myDbContext.Pets.AddAsync(pet);
                await _myDbContext.SaveChangesAsync();
                return pet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task DeleteHobbies(int id)
        {
            IList<Hobby> hobbiesToRemove = new List<Hobby>(_myDbContext.Hobby.Where(f => f.ChildId == id));
            if (hobbiesToRemove.Equals(null))
            {
                Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Hobby.RemoveRange(hobbiesToRemove);
            }

            await _myDbContext.SaveChangesAsync();
        }
        
        public async Task DeletePets(int id)
        {
            IList<Pet> petsToRemove = new List<Pet>(_myDbContext.Pets.Where(f => f.ChildId == id));
            if (petsToRemove.Equals(null))
            {
                Console.WriteLine("null");   
            }
            else
            {
                _myDbContext.Pets.RemoveRange(petsToRemove);
            }

            await _myDbContext.SaveChangesAsync();
        }
    }
}