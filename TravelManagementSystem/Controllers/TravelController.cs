using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace TravelManagementSystem.Controllers
{
    public class TravelController : ApiController
    {
        [HttpGet]
        [Route("api/bookings")]

        public HttpResponseMessage Bookings()
        {
            try
            {
                var data = BookingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/bookings/{id}")]
        public HttpResponseMessage GetBooking(int id)
        {
            try
            {
                var data = BookingService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/bookings/create")]
        public HttpResponseMessage CreateBooking(BookingDTO bookingDTO)
        {
            try
            {
                var data = BookingService.Create(bookingDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/bookings/update")]
        public HttpResponseMessage UpdateBooking(BookingDTO bookingDTO)
        {
            try
            {
                BookingService.Update(bookingDTO);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/bookings/delete/{id}")]
        public HttpResponseMessage DeleteBooking(int id)
        {
            try
            {
                BookingService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message });
            }
        }


        [HttpGet]
            [Route("api/bookings/{id}/suggestions")]
            public HttpResponseMessage BookingSuggestions(int id)
            {
                try
                {
                    var data = BookingService.GetwithSuggestions(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
        }




  
}
