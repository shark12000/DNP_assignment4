using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;
using DoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoAPI.Controllers
{
    [Route("user/{userId}/family")]
    [ApiController] 
    public class FamilyController : ControllerBase 
    {
        private readonly IFamilyService _familyService;
        public FamilyController(IFamilyService familyService)
        {
            _familyService = familyService; 
        }
        
        [Route("/family")]
        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Family added = await _familyService.AddAsync(family);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/family")]
        [HttpPatch]
        public async Task<ActionResult<Family>> UpdateFamily([FromBody] Family family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Family updated = await _familyService.Update(family);
                return Ok(updated);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/family")]
        public async Task<ActionResult<IList<Family>>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Family> added = await _familyService.GetAsync();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/family/{familyId}")]
        public async Task<ActionResult<Family>>GetFamily(int familyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Family found = await _familyService.GetFamily(familyId);
                return Ok(found);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Family>>> Get(int userId)
        {
            try
            {
                IList<Family> added = await _familyService.GetAsync(userId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/family/{familyId}")]
        [HttpDelete]
        public async Task<ActionResult<Family>> Remove(int familyId)
        {
            try
            {
                Console.WriteLine(familyId + "Remove");
                await _familyService.DeleteAsync(familyId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}