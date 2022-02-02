using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    //TODO: remove temporary /c/ for commands service - will be more clear later
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Commands Service");

            return Ok("Inbound test of from Platforms Controller");
        }
    } 
}