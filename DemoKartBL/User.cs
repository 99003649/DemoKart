using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
     public class User
    {
        string user1 = "user";
        string pass1 = "pass";
        string user2 = "pat";
        string pass2 = "andrews";
        string user3 = "nishant";
        string pass3 = "hawaliya";
        string user4 = "riya";
        string pass4 = "gupta";
        public int LoginCheck(string user, string pass)
        {
            if (user1 == user && pass1 == pass || user2 == user && pass2 == pass || user3 == user && pass3 == pass || user4 == user && pass4 == pass)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
