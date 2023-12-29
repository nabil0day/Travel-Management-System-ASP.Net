using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SuggestionDTO
    {
        public int Id { get; set; }
        public string SuggestedText { get; set; }
        public DateTime Time { get; set; }
        public string SuggestedBy { get; set; }
        public int BookedId { get; set; }
    }
}
