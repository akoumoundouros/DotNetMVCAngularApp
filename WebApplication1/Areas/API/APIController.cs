using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Areas.API
{
    public class APIController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Test()
        {
            string data = "success";
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
    }
}
