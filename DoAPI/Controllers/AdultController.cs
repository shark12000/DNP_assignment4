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
    public class AdultController : ControllerBase
    {
        private readonly IAdultService _adultService;
        public AdultController(IAdultService adultService)
        {
            _adultService = adultService; 
        }
        
        [Route("/adult")]
        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult added = await _adultService.AddAsync(adult);
                return added;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [Route("/adult")]
        [HttpGet]
        public async Task<ActionResult<List<Adult>>> GetAllAdults()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Adult> added = await _adultService.GetAllAdultsAsync();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        [Route("/adult/{adultId}")]
        public async Task<ActionResult<Adult>>GetAdult(int adultId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult found = await _adultService.GetAdult(adultId);
                return Ok(found);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdultsByFamily(int familyId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Adult> added = await _adultService.GetAsync(familyId);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/adult/{adultId}")]
        [HttpDelete]
        public async Task<ActionResult<Family>> Remove(int adultId)
        {
            try
            {
                Console.WriteLine(adultId + "Remove");
                await _adultService.DeleteAsync(adultId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/adult")]
        [HttpPatch]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult updated = await _adultService.Update(adult);
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