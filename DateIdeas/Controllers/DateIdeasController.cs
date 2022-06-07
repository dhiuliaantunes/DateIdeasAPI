using DateIdeas.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateIdeas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateIdeasController : ControllerBase
    {
        private readonly IDateBusiness _business;

        private readonly ILogger<DateIdeasController> _logger;

        public DateIdeasController(ILogger<DateIdeasController> logger, IDateBusiness business)
        {
            _logger = logger;
            _business = business;
        }

        [HttpGet("RainyDay")]
        public IActionResult GetRainyDate()
        {
            var result =  _business.RandomRainyDate();
            if(result != null) return Ok(result);
            return BadRequest();
        }

        [HttpGet("SunnyDay")]
        public IActionResult GetSunnyDate()
        {
            var result = _business.RandomSunnyDate();
            if (result != null) return Ok(result);
            return BadRequest();
        }
    }
}
