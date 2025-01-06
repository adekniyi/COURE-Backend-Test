using CountryDetailsProject.DTOs;
using CountryDetailsProject.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryDetailsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }



        [HttpGet]
        public IActionResult GetCountryByCode([FromQuery]CountryRequestDTO request)
        {
            var result = _countryRepository.GetCountryByCode(request.phoneNumber);

            return result.Success ? Ok(result.Data) : StatusCode(result.StatusCode, result.Message);
        }
    }
}
