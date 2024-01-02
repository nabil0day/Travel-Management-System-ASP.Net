using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class ComplainRepo : Repo, IRepo<Complain, int, bool>
    {
        public bool Create(Complain obj)
        {
            db.Complains.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var existingComplain = Read(id);
            if (existingComplain != null)
            {
                db.Complains.Remove(existingComplain);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Complain> Read()
        {
            return db.Complains.ToList();
        }

        public Complain Read(int id)
        {
            return db.Complains.Find(id);
        }

        public bool Update(Complain obj)
        {
            var existingComplain = Read(obj.Id);
            if (existingComplain != null)
            {
                db.Entry(existingComplain).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
