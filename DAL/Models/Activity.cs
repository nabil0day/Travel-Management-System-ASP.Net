using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Activity
    {
        public int Id { get; set; }

        [Required]
        public string Activity_Title { get; set; }

        [Required]
        public string Activity_Description { get; set; }

        [ForeignKey("User")]
        public string CreatedBy { get; set; }

        public DateTime Date { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public Activity()
        {
            Feedbacks = new List<Feedback>();
        }
    }
}