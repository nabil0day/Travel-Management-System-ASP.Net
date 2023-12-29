using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BookingDTO
    {
        public int Id { get; set; }
        [Required]
        public string Booking_Title { get; set; }
        [Required]
        public string Booking_Descripion { get; set; }
        [Required]
        public string BookedBy { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
