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
        [TestMethod()]
        public void AddNumberTest()
        {
            var hue = new Hue(100, HueType.dgr);
            hue = hue + 5;
            Assert.AreEqual("105°", hue.Output());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var hue = new Hue(100, HueType.dgr);
            hue = hue - 5;
            Assert.AreEqual("95°", hue.Output());
        }
        [TestMethod()]
        public void PercentToAnyTest()
        {
            Hue hue = new Hue(60, HueType.prcnt);
            Assert.AreEqual("216°", hue.To(HueType.dgr).Output());
            Assert.AreEqual("0,6", hue.To(HueType.thng).Output());
        }
        [TestMethod()]
        public void AnyToPercentTest()
        {
            Hue hue = new Hue(216, HueType.dgr);
            Assert.AreEqual("60%", hue.To(HueType.prcnt).Output());
            hue = new Hue(0.6, HueType.thng);
            Assert.AreEqual("60%", hue.To(HueType.prcnt).Output());
        }
        [TestMethod()]
        public void AnyToAnyTest()
        {
            Hue hue = new Hue(216, HueType.dgr);
            Assert.AreEqual("0,6", hue.To(HueType.thng).Output());
            hue = new Hue(0.6, HueType.thng);
            Assert.AreEqual("216°", hue.To(HueType.dgr).Output());
        }
    }
}