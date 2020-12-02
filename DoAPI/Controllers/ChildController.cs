using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;
using DoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoAPI.Controllers
{
    [Route("family/{familyId}/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService; 
        }
        
        [Route("/child")]
        [HttpPost]
        public async Task<ActionResult<Child>> AddChild([FromBody] Child child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child added = await _childService.AddAsync(child);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/pets")]
        [HttpPost]
        public async Task<ActionResult<Pet>> AddPet([FromBody] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Pet added = await _childService.AddPet(pet);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/hobby")]
        [HttpPost]
        public async Task<ActionResult<Hobby>> AddHobby([FromBody] Hobby hobby)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Hobby added = await _childService.AddHobby(hobby);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child/{childId}/pet")]
        [HttpGet]
        public async Task<ActionResult<IList<Pet>>> GetPets(int childId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Pet> added = await _childService.GetChildPets(childId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child/{childId}/hobby")]
        [HttpGet]
        public async Task<ActionResult<IList<Hobby>>> GetHobbies(int childId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Hobby> added = await _childService.GetChildHobbies(childId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        

        [Route("/child")]
        [HttpGet]
        public async Task<ActionResult<List<Child>>> GetAllChildren()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Child> added = await _childService.GetAllChildrenAsync();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/hobby")]
        [HttpGet]
        public async Task<ActionResult<List<Hobby>>> GetAllHobbies()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Hobby> added = await _childService.GetAllHobbiesAsync();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child/{childId}")]
        public async Task<ActionResult<Child>>GetChild(int childId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child found = await _childService.GetChild(childId);
                return Ok(found);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child/{childId}/pet")]
        [HttpDelete]
        public async Task<ActionResult<Child>> RemovePets(int childId)
        {
            try
            {
                await _childService.DeletePets(childId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        [Route("/child/{childId}/hobby")]
        [HttpDelete]
        public async Task<ActionResult<Child>> DeleteHobbies(int childId)
        {
            try
            {
                await _childService.DeleteHobbies(childId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<Child>>> GetChildrenByFamily(int familyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Child> added = await _childService.GetAsync(familyId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child/{childId}")]
        [HttpDelete]
        public async Task<ActionResult<Child>> Remove(int childId)
        {
            try
            {
                await _childService.DeleteAsync(childId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/child")]
        [HttpPatch]
        public async Task<ActionResult<Child>> UpdateAdult([FromBody] Child child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child updated = await _childService.Update(child);
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