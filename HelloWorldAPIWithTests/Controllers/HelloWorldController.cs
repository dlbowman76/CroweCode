using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldClassLibrary.Models;

namespace HelloWorldAPIWithTests.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET api/HelloWorld
        public string Get()
        {
            messageModel hw = new messageModel();

            //this value could be drawn from a dynamic datasource.
            hw.Message = "Hello World!";

            return hw.Message;
        }
    }
}
