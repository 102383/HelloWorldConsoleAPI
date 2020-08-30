using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsoleApp;
using Microsoft.Extensions.Configuration;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class helloWorldController : ControllerBase
    {
        private readonly IConfiguration _iconfiguration;

        private readonly ILogger<helloWorldController> _logger;

        public helloWorldController(ILogger<helloWorldController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
        }

        [HttpGet]
        public string Get()
        {
            string message = _iconfiguration.GetSection("message").Value;
            string target = _iconfiguration.GetSection("target").Value;
            return MessageWriter.WriteHelloWorld(target, message);
        }
    }
}
