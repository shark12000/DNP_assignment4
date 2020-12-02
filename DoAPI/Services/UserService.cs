using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;

namespace DoAPI.Services
{
    public class UserService : IUserService
    {
        private readonly MyDbContext myDbContext;

        public UserService(MyDbContext context)
        {
           myDbContext = context;
        }

        public async Task<User> GetUser(int id)
        {
            Console.WriteLine(id);
            User first = myDbContext.Users.FirstOrDefault(user => user.Id == id);
            Console.WriteLine(first);
            if (first == null)
            {
                Console.WriteLine("I am null");
            }
            
            return first;
        }

        public async Task<List<User>> GetAsync()
        {
            List<User> tmp = new List<User>(myDbContext.Users);
            return tmp;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await myDbContext.Users.AddAsync(user);
            await myDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> Login(string email, string password)
        {
            Console.WriteLine("I am in Login (Service)");
            Console.WriteLine(email, password);
            User first = myDbContext.Users.FirstOrDefault(user => user.Email.Equals(email));
            if (first == null)
            {
                Console.WriteLine("I am null");
            }
            
            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            
            return first;
        }

        public async Task<User> Register(User user)
        {

            if (myDbContext.Users.FirstOrDefault(x => x.Email.Equals(user.Email)) != null)
            {
                throw new Exception("Email " + user.Email + " already exists");
            }
            
            
            await myDbContext.Users.AddAsync(user);
            await myDbContext.SaveChangesAsync();
            return user;
        }
    }
}