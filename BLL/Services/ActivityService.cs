using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ActivityService
    {
        public static List<ActivityDTO> Get()
        {
            var data = DataAccessFactory.ActivityData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Activity, ActivityDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ActivityDTO>>(data);
            return mapped;
        }
        public static ActivityDTO Get(int id)
        {
            var data = DataAccessFactory.ActivityData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Activity, ActivityDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ActivityDTO>(data);
            return mapped;
        }
        public static ActivityFeedbackDTO GetwithFeedbacks(int id)
        {
            var data = DataAccessFactory.ActivityData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Activity, ActivityFeedbackDTO>();
                c.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ActivityFeedbackDTO>(data);
            return mapped;
        }

    }
}