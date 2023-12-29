using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookingRepo : Repo, IRepo<Booking, int, bool>
    {
        public bool Create(Booking obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var existingBooking = Read(id);
            if (existingBooking != null)
            {
                db.Bookings.Remove(existingBooking);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<Booking> Read()
        {
            return db.Bookings.ToList();
        }

        public Booking Read(int id)
        {
            return db.Bookings.Find(id);
        }

        public bool Update(Booking obj)
        {
            var existingBooking = Read(obj.Id);
            if (existingBooking != null)
            {
                db.Entry(existingBooking).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0)
                    return true;
            }
            return false;
        }
    }

}
