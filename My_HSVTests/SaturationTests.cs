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
    public class SaturationTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var satur = new Saturation(100, SaturationType.prcnt);
            Assert.AreEqual("100%", satur.Output());

            satur = new Saturation(1, SaturationType.thng);
            Assert.AreEqual("1", satur.Output());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var saturation = new Saturation(10, SaturationType.prcnt);
            saturation = saturation + 1;
            Assert.AreEqual("11%", saturation.Output());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var saturation = new Saturation(10, SaturationType.prcnt);
            saturation = saturation - 1;
            Assert.AreEqual("9%", saturation.Output());
        }
        [TestMethod()]
        public void PercentToAnyTest()
        {
            Saturation saturation = new Saturation(60, SaturationType.prcnt);
            Assert.AreEqual("0,6", saturation.To(SaturationType.thng).Output());
        }
        [TestMethod()]
        public void AnyToPercentTest()
        {
            var saturation = new Saturation(0.6, SaturationType.thng);
            Assert.AreEqual("60%", saturation.To(SaturationType.prcnt).Output());
        }
    }
}