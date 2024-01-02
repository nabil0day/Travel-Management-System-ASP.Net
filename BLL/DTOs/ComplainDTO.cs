using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ComplainDTO
    {
        public int Id { get; set; }
        [Required]
        public string ComplainText { get; set; }
        public DateTime Time { get; set; }
        public string ComplainBy { get; set; }
        public int ReviewId { get; set; }
    }
}
