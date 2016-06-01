using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();

           ServiceReference1.RightAngletriangle RHT = sc.getRHT(3, 2);

           double area = sc.getArea(RHT);

           Assert.AreEqual(area, (3 * 2 / 2));
        }
    }
}
