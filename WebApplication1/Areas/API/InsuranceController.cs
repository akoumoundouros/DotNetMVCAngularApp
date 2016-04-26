using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Areas.API
{
    public class InsuranceController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CalculateCoverAmount([FromBody]InsuranceModels.Insurance model)
        {
            if (model == null)
                return Request.CreateResponse(HttpStatusCode.InternalServerError);

            int result = 0;
            int min = 50000;
            int max = 1000000;
            // Formula:
            // Cover Amount Calculation = (Mortgage or Rent*12*20) + (no. of Children * 50,000) + Debt
            result = model.mortgage + (model.rent * 12 * 20) + (model.children * 50000) + model.debt;

            if (result >= min && result <= max)
                return Request.CreateResponse(HttpStatusCode.OK, result);
            else
                return Request.CreateResponse(HttpStatusCode.OK, "Invalid range");
        }
    }
}
