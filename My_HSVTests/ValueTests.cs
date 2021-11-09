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
        [TestMethod()]
        public void AddNumberTest()
        {
            var value = new Value(10, ValueType.prcnt);
            value = value + 1;
            Assert.AreEqual("11%", value.Output());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var value = new Value(10, ValueType.prcnt);
            value = value - 1;
            Assert.AreEqual("9%", value.Output());
        }
        [TestMethod()]
        public void PercentToAnyTest()
        {
            Value value = new Value(60, ValueType.prcnt);
            Assert.AreEqual("0,6", value.To(ValueType.thng).Output());
        }
        [TestMethod()]
        public void AnyToPercentTest()
        {
            var value = new Value(0.6, ValueType.thng);
            Assert.AreEqual("60%", value.To(ValueType.prcnt).Output());
        }
    }
}