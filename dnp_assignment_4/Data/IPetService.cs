using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace dnp_assignment_4.Data
{
    public interface IPetService
    {
        Task<string> RemovePet(int petId);
        Task<string> CreatePet(Pet pet);
        Task<string> Update(Pet pet);
        Task<IList<Pet>> GetPetsByFamily(int familyId);
        Task<Pet> GetPet(int petId);
    }
}