using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dnp_assignment_4.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace dnp_assignment_4.Data
{
    public class FamilyService : IFamilyService
    {
        private HttpClient _httpClient;
        
        public FamilyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IList<Family>> GetAllFamilies()
        {
            try
            {
                Task<IList<Family>> family = _httpClient.GetJsonAsync<IList<Family>>("family");
                var families = await family;
                return families;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<IList<Family>> GetCurrentUserFamilies(int id)
        {
            try
            {
                Task<IList<Family>> family = _httpClient.GetJsonAsync<IList<Family>>("user/"+id+"/family");
                var families = await family;
                return families;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
        
        public async Task<Family> GetFamily(int familyId)
        {
            try
            {
                Task<Family> familyS = _httpClient.GetJsonAsync<Family>("family/"+familyId);
                Family family = await familyS;
                return family;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<string> Update(Family family)
        {
            string familySerialized = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PatchAsync("family", content);
            Console.WriteLine("I am patched");
            return response.ToString();
        }

        public async Task<string> CreateFamily(Family family)
        {
            string familySerialized = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PostAsync("family", content);
            Console.WriteLine("I am here");
            return response.ToString();
        }
        
        public async Task<string> RemoveFamily(int familyId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("family/"+familyId);
            Console.WriteLine("I am here");
            return response.ToString();
        }
    }
}