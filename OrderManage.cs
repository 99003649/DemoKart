using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website
{
    class OrderManage
    {
        public string customer_name;
        public string customer_address;
        public long customer_phone_no;

        public string getInfo(string name, string address, long phone)
        {
            customer_name = name;
            customer_address = address;
            customer_phone_no = phone;

            return customer_name + "\n" + customer_address + "\n" + customer_phone_no;
        }
    }
}
