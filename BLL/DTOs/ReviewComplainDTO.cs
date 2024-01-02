using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewComplainDTO :ReviewDTO
    {
        public List<ComplainDTO> Complains { get; set; }
        public ReviewComplainDTO()
        {
            Complains = new List<ComplainDTO>();
        }
    }
}
