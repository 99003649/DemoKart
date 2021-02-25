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
    public class OrderManageTests
    {
        [TestMethod()]
        public void GetInfoTest()
        {
            OrderManage ordObj = new OrderManage();
            ordObj.GetInfo("riya", "404 global mansion", 1234567890);
            Assert.IsNotNull(ordObj);
        }
    }
}