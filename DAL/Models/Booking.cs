using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [Required]
        public string Booking_Title { get; set; }
        [Required]
        public string Booking_Descripion { get; set; }

        [ForeignKey("User")]
        public string BookedBy { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set;}
        public Booking() { 
            Suggestions = new List<Suggestion>();
        }

    }
}
