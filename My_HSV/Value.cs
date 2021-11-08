using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_HSV
{
    public enum ValueType { prcnt, thng };
    public class Value
    {
        private double value;
        private ValueType type;
        public Value(double value, ValueType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Output()
        {
            string typeOutput = "";
            switch (this.type)
            {
                case ValueType.prcnt:
                    typeOutput = "%";
                    break;
                case ValueType.thng:
                    typeOutput = "";
                    break;
            }
            return (Convert.ToString(value) + typeOutput);
        }
    }
}
