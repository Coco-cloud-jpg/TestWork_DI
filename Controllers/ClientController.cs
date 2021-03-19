using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Client> Get()
        {
            var temp = Creator.SetDefault() as Client;
            temp.AnounceArrival();
            return Ok(Creator.SetDefault());
        }
    }
}
