using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.DataAccess;
using DoAPI.Models;
using DoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoAPI.Controllers
{
    [Route("family/{familyId}/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;
        public PetController(IPetService petService)
        {
            _petService = petService; 
        }
        
        [Route("/pet")]
        [HttpPost]
        public async Task<ActionResult<Pet>> AddPet([FromBody] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Pet added = await _petService.AddAsync(pet);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [Route("/pet")]
        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetAllPets()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Pet> added = await _petService.GetAllPetsAsync();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [Route("/pet/{petId}")]
        public async Task<ActionResult<Pet>>GetPet(int petId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Pet found = await _petService.GetPet(petId);
                return Ok(found);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<Pet>>> GetPetsByFamily(int familyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Pet> added = await _petService.GetAsync(familyId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/pet/{petId}")]
        [HttpDelete]
        public async Task<ActionResult<Pet>> Remove(int petId)
        {
            try
            {
                await _petService.DeleteAsync(petId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/pet")]
        [HttpPatch]
        public async Task<ActionResult<Pet>> UpdateAdult([FromBody] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Pet updated = await _petService.Update(pet);
                return Ok(updated);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, e.Message);
            }
        }
    }
}