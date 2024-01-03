using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ActivityFeedbackDTO : ActivityDTO
    {
        public List<FeedbackDTO> Feedbacks { get; set; }
        public ActivityFeedbackDTO()
        {
            Feedbacks = new List<FeedbackDTO>();
        }
    }
}
