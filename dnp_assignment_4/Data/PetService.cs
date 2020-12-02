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
    public class PetService : IPetService
    {
        private HttpClient _httpClient;
        
        public PetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pet> GetPet(int petId)
        {
            try
            {
                Task<Pet> pet = _httpClient.GetJsonAsync<Pet>("pet/"+petId);
                Pet petS = await pet;
                return petS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        
        public async Task<IList<Pet>> GetPetsByFamily(int familyId)
        {
            try
            {
                Task<IList<Pet>> pets = _httpClient.GetJsonAsync<IList<Pet>>("family/"+familyId+"/pet");
                IList<Pet> petS = await pets;
                return petS;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<string> Update(Pet pet)
        {
            string petSerialized = JsonSerializer.Serialize(pet);
            StringContent content = new StringContent(
                petSerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PatchAsync("pet", content);
            return response.ToString();
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
                HttpResponseMessage response = await _httpClient.PostAsync("pet", content);
                return response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> RemovePet(int petId)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("pet/"+petId);
            return response.ToString();
        }
    }
}