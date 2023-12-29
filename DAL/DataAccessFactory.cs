using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Booking,int,bool>BookingData()
        {
            return new BookingRepo();
        }
        public static IRepo<Suggestion, int, bool> SuggestionData()
        {
            return new SuggestionRepo();
        }
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
    }
}
