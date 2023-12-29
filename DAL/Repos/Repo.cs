using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Repo
    {
        internal TravelContext db;
        internal Repo() {
            db = new TravelContext();
            
        }
    }
}
