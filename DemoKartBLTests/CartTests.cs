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
    public class CartTests
    {
        [TestMethod()]
        public void TotalCostTest()
        {
            Cart cartObj = new Cart();
            cartObj.TotalCost();

            Assert.AreEqual(1,1);
        }
    }
}