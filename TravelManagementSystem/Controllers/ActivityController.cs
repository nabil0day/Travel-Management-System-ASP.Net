using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace TravelManagementSystem.Controllers
{
    public class ActivityController : ApiController
    {
        [HttpGet]
        [Route("api/activities")]
        public HttpResponseMessage Activtities()
        {
            try
            {
                var data = ActivityService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/activities/{id}/feedbacks")]
        public HttpResponseMessage ActivityFeedback(int id)
        {
            try
            {
                var data = ActivityService.GetwithFeedbacks(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}