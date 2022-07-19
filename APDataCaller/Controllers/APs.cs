using APDateRetriever;
using static APDateRetriever.Table;
using Microsoft.AspNetCore.Mvc;

namespace APDataCaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APs : ControllerBase
    {
        AccessPointGetResponce Responce = GetAccessPointResponce().Result;
        [HttpGet(Name ="Aps")]

        public AccessPointGetResponce Get()
        {
            return Responce;
        }
        ClientGetResponce ClientResponce = GetClientResponce(0).Result;
        [HttpGet("Clients")]
        public ClientGetResponce Clients()
        {
            return ClientResponce;
        }

        [HttpGet("UpdateClients")]
        public void updateClients()
        {
            UpDateClients(ClientResponce);
        }
        [HttpGet("InsertData")]
        public void InsertData()
        {
            foreach (var point in Responce.Data)
            {
                InsertAP(point.Name, point.Mac);
                foreach (var Client in ClientResponce.Data)
                {
                    if (Client.APMac == point.Mac && Client.Essid == "FreeGardenWIFI")
                    {
                        InsertClient(Client.APMac, Client.UserId);
                    }
                }
            }
        }
    }
}
