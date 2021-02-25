using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
   public class OrderManage
    {
        public string customer_name;
        public string customer_address;
        public long customer_phone_no;

        public string GetInfo(string name, string address, long phone)
        {
            customer_name = name;
            customer_address = address;
            customer_phone_no = phone;

            return "\n Receiver's Address "+customer_name + "\n Receiver's " + customer_address + "\n Receiver's " + customer_phone_no;
        }
    }
}
