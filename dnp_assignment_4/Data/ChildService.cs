using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dnp_assignment_4.Models;
using Microsoft.AspNetCore.Components;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace dnp_assignment_4.Data
{
    public class ChildService : IChildService
    {
       private HttpClient _httpClient;
        
        public ChildService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IList<Child>> GetFamilyChildren(int familyId)
        {
            try
            {
                Task<IList<Child>> child = _httpClient.GetJsonAsync<IList<Child>>("family/"+familyId+"/child");
                var children = await child;
                return children;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Child> GetChild(int childId)
        {
            try
            {
                Task<Child> child = _httpClient.GetJsonAsync<Child>("child/"+childId);
                Child childS = await child;
                return childS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<IList<Child>> GetChildrenByFamily(int familyId)
        {
            try
            {
                Task<IList<Child>> adults = _httpClient.GetJsonAsync<IList<Child>>("family/"+familyId+"/child");
                IList<Child> adultS = await adults;
                return adultS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<string> Update(Child child)
        {
            string familySerialized = JsonSerializer.Serialize(child);
            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PatchAsync("child", content);
            Console.WriteLine("I am patched");
            return response.ToString();
        }

        public async Task<string> CreateChild(Child child)
        {
            try
            {
                string adultSerialized = JsonSerializer.Serialize(child);
                StringContent content = new StringContent(
                    adultSerialized,
                    Encoding.UTF8,
                    "application/json"
                );
                HttpResponseMessage response = await _httpClient.PostAsync("child", content);
                return response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> RemoveHobby(int hobbyId, int childId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("child/"+childId+"/hobby/"+hobbyId);
            return response.ToString();
        }
        
        public async Task<IList<Hobby>> GetAllHobbies()
        {
            try
            {
                Task<IList<Hobby>> hobby = _httpClient.GetJsonAsync<IList<Hobby>>("hobby");
                var hobbies = await hobby;
                return hobbies;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public async Task<string> CreateHobby(Hobby hobby)
        {
            try
            {
                string hobbySerialized = JsonSerializer.Serialize(hobby);
                StringContent content = new StringContent(
                    hobbySerialized,
                    Encoding.UTF8,
                    "application/json"
                );
                HttpResponseMessage response = await _httpClient.PostAsync("hobby", content);
                return response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public async Task<string> CreatePet(Pet pet)
        {
            try
            {
                string petSerialized = JsonSerializer.Serialize(pet);
                StringContent content = new StringContent(
                    petSerialized,
                    Encoding.UTF8,
                    "application/json"
                );
                HttpResponseMessage response = await _httpClient.PostAsync("pets", content);
                return response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> RemoveChild(int childId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("child/"+childId);
            return response.ToString();
        }
        
        public async Task<string> RemovePet(int petId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("pet/"+petId);
            return response.ToString();
        }

        public async Task<IList<Hobby>> GetHobbies(int childId)
        {
            try
            {
                Task<IList<Hobby>> hobbies = _httpClient.GetJsonAsync<IList<Hobby>>("child/"+childId+"/hobby");
                IList<Hobby> hobbyS = await hobbies;
                return hobbyS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<IList<Pet>> GetPets(int childId)
        {
            try
            {
                Task<IList<Pet>> pets = _httpClient.GetJsonAsync<IList<Pet>>("child/"+childId+"/pet");
                var petS = await pets;
                return petS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}