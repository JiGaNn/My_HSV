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
    }
}