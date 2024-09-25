using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using csharpAPI.Models;
using csharpAPI.Services;

namespace csharpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicHolidaysController : ControllerBase
    {
        private readonly IPublicHolidayService _publicHolidayService;

        public PublicHolidaysController(IPublicHolidayService publicHolidayService)
        {
            _publicHolidayService = publicHolidayService;
        }

        [HttpGet("{country}/{year}")]
        public ActionResult<IEnumerable<PublicHoliday>> GetPublicHolidays(string country, int year)
        {
            var publicHolidays = _publicHolidayService.GetPublicHolidays(country, year);
            if (publicHolidays == null)
            {
                return NotFound();
            }

            return Ok(publicHolidays);
        }
    }
}
