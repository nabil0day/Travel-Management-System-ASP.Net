using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string FeedbackText { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("User")]
        public string FeedbackBy { get; set; }

        [ForeignKey("Activity")]

        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual User User { get; set; }
    }
}
