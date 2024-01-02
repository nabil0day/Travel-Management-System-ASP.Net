using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }

        [Required]
        public string Review_Title { get; set; }

        [Required]
        public string Review_Description { get; set; }

        [Required]
        public string ReviewBy { get; set; }

        public DateTime Date { get; set; }
    }
}

