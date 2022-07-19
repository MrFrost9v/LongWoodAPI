using Microsoft.AspNetCore.Mvc;
using static APDateRetriever.Table;
using APDateRetriever;


namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Percentages : Controller
    {
       [HttpGet(Name = ("Percentages"))]
       public IEnumerable<PercetageData> Get()
        {
            List<PercetageData> data = new List<PercetageData>{GetConservatory(), GetGardens(), GetGiftShop()};
            return data;
        }

       [HttpGet("Conservatory")]
        public PercetageData GetConservatory() 
        { 
            PercetageData Data = PercetageDataMaker("Conservatory");
            return Data;
        }

        [HttpGet("Gardens")]
        public PercetageData GetGardens()
        {
            return PercetageDataMaker("Entry Into Gardens");
        }

        [HttpGet("GiftShop")]
        public PercetageData GetGiftShop()
        {
            return PercetageDataMaker("Gift Shop space");
        }

    }
}
