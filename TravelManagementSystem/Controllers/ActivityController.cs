using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelManagementSystem.Controllers
{
    public class ActivityController : ApiController
    {
        [HttpGet]
        [Route("api/activities")]
        public HttpResponseMessage Activities()
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
        [Route("api/activities/{id}")]
        public HttpResponseMessage GetActivity(int id)
        {
            try
            {
                var data = ActivityService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/activities/create")]
        public HttpResponseMessage CreateActivity(ActivityDTO activityDTO)
        {
            try
            {
                var data = ActivityService.Create(activityDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/activities/update")]
        public HttpResponseMessage UpdateActivity(ActivityDTO activityDTO)
        {
            try
            {
                ActivityService.Update(activityDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/activities/delete/{id}")]
        public HttpResponseMessage DeleteActivity(int id)
        {
            try
            {
                ActivityService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
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
