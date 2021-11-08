using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_HSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_HSV.Tests
{
    [TestClass()]
    public class HueTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var hue = new Hue(100, HueType.dgr);
            Assert.AreEqual("100°", hue.Output());

            hue = new Hue(100, HueType.prcnt);
            Assert.AreEqual("100%", hue.Output());

            hue = new Hue(1, HueType.thng);
            Assert.AreEqual("1", hue.Output());
        }
    }
}