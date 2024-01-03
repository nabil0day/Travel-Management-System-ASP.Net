using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public string FeedbackText { get; set; }
        public DateTime Time { get; set; }   
        public string FeedbackBy { get; set; }
        public int ActivityId { get; set; }
    }
}
