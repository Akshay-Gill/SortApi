using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static SortApi.Models.RectangleModel;

namespace SortApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SortArea([FromBody] List<Rectangle> list)
        {
            try
            {
                foreach (Rectangle r in list)
                {
                    if (r.Height < 0 || r.Width < 0)
                    {
                        var message1 = Request.CreateErrorResponse(HttpStatusCode.Forbidden, "Rectangle sides cannot be negative");
                        return message1;
                    }
                }


                list.Sort((X, Y) => ((X.Height * X.Width).CompareTo(Y.Height * Y.Width)));
                var message = Request.CreateResponse(HttpStatusCode.OK, list);
                return message;
            }
            catch(Exception ex)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                return message;
            }


        }
       
    }
}
