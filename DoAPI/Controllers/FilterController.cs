using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DoAPI.Models;
using DoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController] 
    public class FilterController : ControllerBase
    {
        private readonly IFilterService _filterService;
        public FilterController(IFilterService filterService)
        {
            _filterService = filterService;
        }
        
        [Route("/person")]
        public async Task<ActionResult<IList<Person>>> GetAllPeople()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Person> added = await _filterService.GetAllPeople();
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [Route("/filter/person")]
        public async Task<ActionResult<IList<Person>>> GetPeopleByName([FromQuery] string? name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                IList<Person> added = await _filterService.FindPersonByName(name);
                return Ok(added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}