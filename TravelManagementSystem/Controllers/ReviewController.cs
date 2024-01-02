using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelManagementSystem.Controllers
{
    public class ReviewController : ApiController
    {
        [HttpGet]
        [Route("api/reviews")]
        public HttpResponseMessage Reviews()
        {
            try
            {
                var data = ReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/reviews/{id}")]
        public HttpResponseMessage GetReview(int id)
        {
            try
            {
                var data = ReviewService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/reviews/create")]
        public HttpResponseMessage CreateReview(ReviewDTO reviewDTO)
        {
            try
            {
                var data = ReviewService.Create(reviewDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/reviews/update")]
        public HttpResponseMessage UpdateReview(ReviewDTO reviewDTO)
        {
            try
            {
                ReviewService.Update(reviewDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/reviews/delete/{id}")]
        public HttpResponseMessage DeleteReview(int id)
        {
            try
            {
                ReviewService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/reviews/{id}/complains")]
        public HttpResponseMessage ReviewComplains(int id)
        {
            try
            {
                var data = ReviewService.GetwithComplain(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
