using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ActivityRepo : Repo, IRepo<Activity, int, bool>
    {
        public bool Create(Activity obj)
        {
            db.Activities.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var existingActivity = Read(id);
            if (existingActivity != null)
            {
                db.Activities.Remove(existingActivity);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<Activity> Read()
        {
            return db.Activities.ToList();
        }

        public Activity Read(int id)
        {
            return db.Activities.Find(id);
        }

        public bool Update(Activity obj)
        {
            var existingActivity = Read(obj.Id);
            if (existingActivity != null)
            {
                db.Entry(existingActivity).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }
    }

}