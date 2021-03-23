using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
          CalcLib.Calculation objc=new CalcLib.Calculation
            int n1 = 5;
            int n2 = 5;
            int n3 = 5;
            int result1 = n1 * n2;
            int result2 = n1 * n2 * n3;

            Assert.AreEqual(result1, objc.Square(n1, n2));
            Assert.AreEqual(result2, objc.Cube(n1, n2,n3));

        }
    }
}
