using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloWorldAPI.Controllers.Tests
{
    [TestClass()]
    public class helloWorldControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            ILogger logger = new ILogger();
            IConfiguration iconfiguration = new IConfiguration();

            helloWorldController helloWorldController = new helloWorldController(logger, iconfiguration);
        }
    }
}