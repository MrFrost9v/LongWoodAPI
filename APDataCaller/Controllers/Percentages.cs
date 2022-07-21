using Microsoft.AspNetCore.Mvc;
using static APDateRetriever.Table;
using APDateRetriever;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Text.Json;

namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Percentages : Controller
    {
       [HttpGet(Name = ("Percentages"))]
       public PercetageDataList Get()
        {
            PercetageDataList data = new(GetConservatory(), GetGardens(), GetGiftShop());
            return data;
        }

       [HttpGet("Conservatory")]
       [Produces("application/json")]
        public PercetageData GetConservatory() 
        { 
            PercetageData Data = PercetageDataMaker("Conservatory");
            return Data;
        }

        [HttpGet("Gardens")]
        public PercetageData GetGardens()
        {
            PercetageData Data =  PercetageDataMaker("Entry Into Gardens");
            return Data;
        }

        [HttpGet("GiftShop")]
        public PercetageData GetGiftShop()
        {
            PercetageData Data = PercetageDataMaker("Gift Shop space");
            return Data;
        }

    }
}
