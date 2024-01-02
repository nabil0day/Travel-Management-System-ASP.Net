using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ReviewRepo : Repo, IRepo<Review, int, bool>
    {
        public bool Create(Review obj)
        {
            db.Reviews.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var existingReview = Read(id);
            if (existingReview != null)
            {
                db.Reviews.Remove(existingReview);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Review> Read()
        {
            return db.Reviews.ToList();
        }

        public Review Read(int id)
        {
            return db.Reviews.Find(id);
        }

        public bool Update(Review obj)
        {
            var existingReview = Read(obj.Id);
            if (existingReview != null)
            {
                db.Entry(existingReview).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
