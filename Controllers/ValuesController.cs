using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Json;
using ChangeResponseType.Models;

namespace ChangeResponseType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //returns xml if in header Accept : application/xml is passed
        // GET api/values/json
        [HttpGet("json")]
        public Message GetParam(string msg)
        {
            Message message = new Message{ Value = msg };
            return message;
        }

        //returns always xml
        // GET api/values/xml
        [HttpGet("xml")]
        [Produces("application/xml")]
        public Message GetXML(string msg)
        {
            Message message = new Message{ Value = msg };
            return message;
        }
    }
}
