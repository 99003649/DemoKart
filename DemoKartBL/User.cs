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
        public int LoginCheck(string user, string pass)
        {        
            if(user1 == user && pass1 ==pass)
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
