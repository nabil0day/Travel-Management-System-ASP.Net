using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Suggestion
    {
        public int Id { get; set; }
        public string SuggestedText { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("User")]
        public string SuggestedBy { get; set; }

        [ForeignKey("Booking")]

        public int BookedId { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual User User { get; set; }


    }
}
