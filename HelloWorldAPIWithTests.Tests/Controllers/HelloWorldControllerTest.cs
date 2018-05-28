using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPIWithTests;
using HelloWorldAPIWithTests.Controllers;

namespace HelloWorldAPIWithTests.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            HelloWorldController controller = new HelloWorldController();

            string result = controller.Get();

            Assert.AreEqual("Hello World!", result);
        }
    }
}
