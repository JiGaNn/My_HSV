using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_HSV
{
    public enum HueType { dgr, prcnt, thng };
    public class Hue
    {
        private double value;
        private HueType type;
        public Hue(double value, HueType type)
        {
            this.value = value;
            this.type = type;
        }

        public string Output()
        {
            string typeOutput = "";
            switch (this.type)
            {
                case HueType.dgr:
                    typeOutput = "°";
                    break;
                case HueType.prcnt:
                    typeOutput = "%";
                    break;
                case HueType.thng:
                    typeOutput = "";
                    break;
            }
            return (Convert.ToString(value) + typeOutput);
        }
    }
}
