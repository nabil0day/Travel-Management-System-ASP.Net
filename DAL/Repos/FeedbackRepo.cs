using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FeedbackRepo : Repo, IRepo<Feedback, int, bool>
    {
        public bool Create(Feedback obj)
        {
            db.Feedbacks.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var existingFeedback = Read(id);
            if (existingFeedback != null)
            {
                db.Feedbacks.Remove(existingFeedback);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<Feedback> Read()
        {
            return db.Feedbacks.ToList();
        }

        public Feedback Read(int id)
        {
            return db.Feedbacks.Find(id);
        }

        public bool Update(Feedback obj)
        {
            var existingFeedback = Read(obj.Id);
            if (existingFeedback != null)
            {
                db.Entry(existingFeedback).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }
    }

}