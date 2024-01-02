using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        
        public string Review_Title { get; set; }
        [Required]
        
        public string Review_Description {  get; set; }
        [ForeignKey("User")]
        public string ReviewBy { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }  

        public virtual ICollection<Complain> Complains { get; set; }

        public Review() 
        { 
            Complains = new List<Complain>();
        }

    }
}
