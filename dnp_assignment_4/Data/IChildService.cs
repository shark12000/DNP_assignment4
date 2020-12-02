using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace dnp_assignment_4.Data
{
    public interface IChildService
    {
        Task<string> RemoveChild(int childId);
        Task<string> RemoveHobbies(int childId);
        Task<string> RemovePets(int childId);
        Task<string> CreateChild(Child child);
        Task<string> CreateHobby(Hobby hobby);
        Task<string> CreatePet(Pet pet);
        Task<string> Update(Child child);
        Task<IList<Child>> GetChildrenByFamily(int familyId);
        Task<Child> GetChild(int childId);
        Task<IList<Hobby>> GetHobbies(int childId);
        Task<IList<Hobby>> GetAllHobbies();
        Task<IList<Pet>> GetPets(int childId);

    }
}