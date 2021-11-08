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
    public class ValueTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var value = new Value(100, ValueType.prcnt);
            Assert.AreEqual("100%", value.Output());

            value = new Value(1, ValueType.thng);
            Assert.AreEqual("1", value.Output());
        }
    }
}