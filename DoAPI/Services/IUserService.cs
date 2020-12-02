using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;

namespace DoAPI.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAsync();
        Task<User> GetUser(int id);
        Task<User> AddUserAsync(User user);
        Task<User> Login(string email, string password);
        Task<User> Register(User user);
    }
}