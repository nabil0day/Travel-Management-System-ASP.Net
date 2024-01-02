using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookingService
    {
        public static bool Create(BookingDTO bookingDTO)
        {
            var booking = new Booking();
            booking.Id = bookingDTO.Id;
            booking.Booking_Title = bookingDTO.Booking_Title;
            booking.Booking_Descripion = bookingDTO.Booking_Descripion;
            booking.BookedBy = bookingDTO.BookedBy;
            booking.Date = bookingDTO.Date;

            return DataAccessFactory.BookingData().Create(booking);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.BookingData().Delete(id);
        }

        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory.BookingData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<BookingDTO>>(data);
            return mapped;
        }

        public static BookingDTO Get(int id)
        {
            var data = DataAccessFactory.BookingData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<BookingDTO>(data);
            return mapped;
        }

        public static BookingSuggestionDTO GetwithSuggestions(int id)
        {
            var data = DataAccessFactory.BookingData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingSuggestionDTO>();
                c.CreateMap<Suggestion, SuggestionDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<BookingSuggestionDTO>(data);
            return mapped;
        }

        public static bool Update(BookingDTO bookingDTO)
        {
            var booking = new Booking();
            booking.Id = bookingDTO.Id;
            booking.Booking_Title = bookingDTO.Booking_Title;
            booking.Booking_Descripion = bookingDTO.Booking_Descripion;
            booking.BookedBy = bookingDTO.BookedBy;
            booking.Date = bookingDTO.Date;

            return DataAccessFactory.BookingData().Update(booking);
        }
    }
}
