using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorVersion1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCalculatorVersion1.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        BusinessLogic objWindow = new BusinessLogic();
        //BusiLog objWindow = new BusiLog();
        [TestMethod()]
        public void FetchResultTestAdd()
        {
            double op1 = 9;
            double op2 = 10;

            string result = objWindow.FetchResult("+", op1, op2);

            Assert.AreEqual("19", result);

            Assert.Fail();
        }

        //[TestMethod()]
        //public void FetchResultTestAdd()
        //{
        //    double op1 = 9;
        //    double op2 = 10;

        //    string result = objWindow.FetchResult("+", op1, op2);

        //    Assert.Inconclusive("Just failed");

        //}
    }
}