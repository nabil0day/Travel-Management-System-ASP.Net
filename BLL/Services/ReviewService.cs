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
    public class ReviewService
    {
        public static bool Create(ReviewDTO reviewDTO)
        {
            var review = new Review();
            review.Id = reviewDTO.Id;
            review.Review_Title = reviewDTO.Review_Title;
            review.Review_Description = reviewDTO.Review_Description;
            review.ReviewBy = reviewDTO.ReviewBy;
            review.Date = reviewDTO.Date;

            return DataAccessFactory.ReviewData().Create(review);

        }

        public static bool Update(ReviewDTO reviewDTO)
        {
            var review = new Review();
            review.Id = reviewDTO.Id;
            review.Review_Title = reviewDTO.Review_Title;
            review.Review_Description = reviewDTO.Review_Description;
            review.ReviewBy = reviewDTO.ReviewBy;
            review.Date = reviewDTO.Date;

            return DataAccessFactory.ReviewData().Update(review);
        }
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewData().Read();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }

        public static ReviewDTO Get(int id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }

        public static ReviewComplainDTO GetwithComplain(int id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewComplainDTO>();
                c.CreateMap<Complain, ComplainDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ReviewComplainDTO>(data);
            return mapped;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ReviewData().Delete(id);
        }
    }
}
