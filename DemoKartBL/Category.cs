using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal
{
    class Categories
    {
        public int C_id;
        public string C_name;

        public Categories()
        {
            C_id = 0;
            C_name = null;

        }
        public Categories(int Id, string Name)
        {
            this.C_id = Id;
            this.C_name = Name;
        } 
    }
}
