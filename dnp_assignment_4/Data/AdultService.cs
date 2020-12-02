using System;
using System.Collections;
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
    public class AdultService : IAdultService
    {
        private HttpClient _httpClient;
        
        public AdultService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IList<Adult>> GetFamilyAdults(int familyId)
        {
            try
            {
                Task<IList<Adult>> adult = _httpClient.GetJsonAsync<IList<Adult>>("family/"+familyId+"/adult");
                var adults = await adult;
                return adults;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Adult> GetAdult(int adultId)
        {
            try
            {
                Task<Adult> adult = _httpClient.GetJsonAsync<Adult>("adult/"+adultId);
                Adult adultS = await adult;
                return adultS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<IList<Adult>> GetAdultsByFamily(int familyId)
        {
            try
            {
                Task<IList<Adult>> adults = _httpClient.GetJsonAsync<IList<Adult>>("family/"+familyId+"/adult");
                IList<Adult> adultS = await adults;
                return adultS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<string> Update(Adult adult)
        {
            string familySerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                familySerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PatchAsync("adult", content);
            Console.WriteLine("I am patched");
            return response.ToString();
        }

        public async Task<string> CreateAdult(Adult adult)
        {
            try
            {
                string adultSerialized = JsonSerializer.Serialize(adult);
                StringContent content = new StringContent(
                    adultSerialized,
                    Encoding.UTF8,
                    "application/json"
                );
                HttpResponseMessage response = await _httpClient.PostAsync("adult", content);
                return response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> RemoveAdult(int adultId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("adult/"+adultId);
            return response.ToString();
        }
    }
}