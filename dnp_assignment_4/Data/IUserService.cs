using System.Collections.Generic;
using System.Threading.Tasks;
using dnp_assignment_4.Models;

namespace dnp_assignment_4.Data
{
    public interface IUserService
    {
        Task<string> RegisterUser(User user);
        Task<User> LoginUser(string email, string password);
    }
}