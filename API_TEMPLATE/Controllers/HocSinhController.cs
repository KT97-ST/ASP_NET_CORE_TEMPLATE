using Data;
using Microsoft.AspNetCore.Mvc;

namespace API_TEMPLATE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HocSinhController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<HocSinhController> _logger;

        public HocSinhController(ILogger<HocSinhController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public HocSinhDetail Get()
        {
            return new HocSinhDetail() { Name = "KIM THANh" };
        }


        [HttpGet("{Id}")]
        public HocSinhDetail Get(int id )
        {
            if (id == 0)
            {
                return new HocSinhDetail() { Name = "KIM THANh" };
            }
            return new HocSinhDetail() { Name = "Not me" };
        }
    }
}