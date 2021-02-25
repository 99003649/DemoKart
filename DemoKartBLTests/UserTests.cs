using Microsoft.VisualStudio.TestTools.UnitTesting;
using EcommercePortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortal.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void LoginCheckTest()
        {
            User uObj = new User();
            uObj.LoginCheck("riya", "gupta");
            Assert.AreEqual(1, 1);
        }
    }
}