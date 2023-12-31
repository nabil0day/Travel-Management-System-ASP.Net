using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ActivityDTO
    {
        public int Id { get; set; }

        [Required]
        public string Activity_Title { get; set; }

        [Required]
        public string Activity_Description { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime Date { get; set; }
    }
}