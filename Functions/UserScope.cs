using Database_Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class UserScope
    {
        public static AppDbContext Db { get;set;} = new AppDbContext();
        
        public static bool IsValid(string userName, string password)
        {
            //foreach(var user in Db.User) //
            //{
            //    if (user.Username == userName && user.Password == password)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            return Db.User.Any(user => user.Username.Contains(userName) && user.Password.Contains(password)); // tra ve true neu ton tai 1 item neu thoa
        }
    }
}
