using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_HSV
{
    public enum SaturationType { prcnt, thng };
    public class Saturation
    {
        private double value;
        private SaturationType type;
        public Saturation(double value, SaturationType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Output()
        {
            string typeOutput = "";
            switch (this.type)
            {
                case SaturationType.prcnt:
                    typeOutput = "%";
                    break;
                case SaturationType.thng:
                    typeOutput = "";
                    break;
            }
            return (Convert.ToString(value) + typeOutput);
        }
    }
}
