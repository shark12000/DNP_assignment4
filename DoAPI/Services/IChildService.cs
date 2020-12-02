using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IChildService
    {
        Task<IList<Child>> GetAsync(int familyId);
        Task<Child> GetChild(int childId);
        Task<IList<Child>> GetAllChildrenAsync();
        Task<IList<Hobby>> GetAllHobbiesAsync();
        Task<Child> AddAsync(Child child);
        Task<Child> Update(Child child);
        Task DeleteAsync(int id);
        Task DeleteHobbies(int id);
        Task DeletePets(int id);
        Task<IList<Pet>> GetChildPets(int childId);
        Task<IList<Hobby>> GetChildHobbies(int childId);
        Task<Hobby> AddHobby(Hobby hobby);
        Task<Pet> AddPet(Pet pet);
    }
}