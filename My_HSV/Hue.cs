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
        public static Hue operator +(Hue instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var hue = new Hue(newValue, instance.type);
            // возвращаем результат
            return hue;
        }
        public static Hue operator +(double number, Hue instance)
        {
            return instance + number;
        }
        public static Hue operator -(Hue instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value - number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var hue = new Hue(newValue, instance.type);
            // возвращаем результат
            return hue;
        }
        public static Hue operator -(double number, Hue instance)
        {
            return instance - number;
        }

        public Hue To(HueType newType)
        {
            var newValue = this.value;
            if(this.type == HueType.prcnt)
            {
                switch(newType)
                {
                    case HueType.dgr:
                        newValue = this.value * 3.6;
                        break;
                    case HueType.thng:
                        newValue = this.value / 100;
                        break;
                }
            }else if(newType == HueType.prcnt)
            {
                switch(this.type)
                {
                    case HueType.dgr:
                        newValue = this.value / 3.6;
                        break;
                    case HueType.thng:
                        newValue = this.value * 100;
                        break;
                }
            }
            else
            {
                newValue = this.To(HueType.prcnt).To(newType).value;
            }
            return new Hue(newValue, newType);
        }
    }
}
