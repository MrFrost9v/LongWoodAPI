using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static APDateRetriever.Table;
using static APDateRetriever.PeopleSensor;
using APDateRetriever;
namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleSensorController : ControllerBase
    {
        PeopleResponce Responce = PeopleSensor.GetPeopleData(GetToken().Result.AccessToken, client).Result;
        // GET: PeopleData
        [HttpGet(Name = "Results")]
        public PeopleResponce Get()
        {
            return Responce;
        }

        // GET: PeopleData/Id
        [HttpGet("UpdateData")]
        public void UpdateData()
        {
            foreach (var item in Responce.Results)
            {
                UpDateSensorData(item.Name, item.MaxOccupancy, item.SumIns, item.DateTime);
            }
        }
    }
}
