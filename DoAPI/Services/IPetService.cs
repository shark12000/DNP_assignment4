using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IPetService
    {
        Task<IList<Pet>> GetAsync(int familyId);
        Task<Pet> GetPet(int petId);
        Task<IList<Pet>> GetAllPetsAsync();
        Task<Pet> AddAsync(Pet pet);
        Task<Pet> Update(Pet pet);
        Task DeleteAsync(int id);
    }
}