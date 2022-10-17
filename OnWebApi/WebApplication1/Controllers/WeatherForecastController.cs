using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.AttributeManagement;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly ITransportService _transportService;

        public WeatherForecastController()
        {
            //_transportService = transportService;
        }

        [HttpGet]
        [ServiceFilter(typeof(DuplicateOperationsAttribute))]
        public List<string> Get()
        {
            return new List<string>()
            {
                "a", "b", "c"
            };
        }
    }

}
