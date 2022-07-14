using Microsoft.AspNetCore.Mvc;
using static APDateRetriever.Table;

namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SensorsToAPs : ControllerBase
    {
        [HttpGet(Name = "UpdateSToAPs")]
        public void Get()
        {
            UpDateSensorToAP();
        }
    }
}
