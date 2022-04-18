using SortApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SortApi.Models;
using SortApi.Business;

namespace SortApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ILogic _logic;

        public ValuesController()
        {
            Logic logic = new Logic();
            _logic = logic;
        }

        public ValuesController(ILogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        public HttpResponseMessage SortArea([FromBody] List<Rectangle> list, string sortBy = "asc")
        {
            try
            {
                if (!ModelState.IsValid || (sortBy != "asc" && sortBy != "desc"))
                {
                    var message1 = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Rectangle sides cannot be negative");
                    return message1;
                }

                var sortedList = _logic.SortRectangle(list, sortBy);
                var message = Request.CreateResponse(HttpStatusCode.OK, sortedList);
                return message;
            }
            catch (Exception ex)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                return message;
            }

        }
       
    }
}
