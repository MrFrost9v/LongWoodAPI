using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        // GET: Test
        [HttpGet(Name = "Test")]
        public string Test()
        {
            return "glow";
        }

        // GET: Test/Id
        [HttpGet("id")]
        public int Details(int id)
        {
            return id;
        }
    }
}
