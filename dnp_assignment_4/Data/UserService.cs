using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dnp_assignment_4.Models;
using Microsoft.AspNetCore.Components;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace dnp_assignment_4.Data
{
    public class UserService : IUserService
    {

        private HttpClient _httpClient;
        

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<string> RegisterUser(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PostAsync("user", content);
            Console.WriteLine("I am here");
            return response.ToString();
        }

        public async Task<User> LoginUser(string email, string password)
        {
            return await _httpClient.GetJsonAsync<User>("user/?email=" + email + "&password=" + password);
        }
    }
}