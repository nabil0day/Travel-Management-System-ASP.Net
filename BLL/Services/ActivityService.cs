using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ActivityService
    {
        public static bool Create(ActivityDTO activityDTO)
        {
            var activity = new Activity();
            activity.Id = activityDTO.Id;
            activity.Activity_Title = activityDTO.Activity_Title;
            activity.Activity_Description = activityDTO.Activity_Description;
            activity.CreatedBy = activityDTO.CreatedBy;
            activity.Date = activityDTO.Date;

            return DataAccessFactory.ActivityData().Create(activity);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ActivityData().Delete(id);
        }

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

        public static bool Update(ActivityDTO activityDTO)
        {
            var activity = new Activity();
            activity.Id = activityDTO.Id;
            activity.Activity_Title = activityDTO.Activity_Title;
            activity.Activity_Description = activityDTO.Activity_Description;
            activity.CreatedBy = activityDTO.CreatedBy;
            activity.Date = activityDTO.Date;

            return DataAccessFactory.ActivityData().Update(activity);

        }
    }
}
