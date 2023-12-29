using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SuggestionRepo : Repo, IRepo<Suggestion, int, bool>
    {
        public bool Create(Suggestion obj)
        {
            db.Suggestions.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var existingSuggestion = Read(id);
            if (existingSuggestion != null)
            {
                db.Suggestions.Remove(existingSuggestion);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<Suggestion> Read()
        {
            return db.Suggestions.ToList();
        }

        public Suggestion Read(int id)
        {
            return db.Suggestions.Find(id);
        }

        public bool Update(Suggestion obj)
        {
            var existingSuggestion = Read(obj.Id);
            if (existingSuggestion != null)
            {
                db.Entry(existingSuggestion).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }
    }
}
