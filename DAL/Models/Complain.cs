using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Complain
    {
        public int Id { get; set; }
        
        public string ComplainText { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("User")]
        public string ComplainBy { get; set;}
        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }
        public virtual User User { get; set; }
        


    }
}
