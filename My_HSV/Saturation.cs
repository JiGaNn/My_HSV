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
        public static Saturation operator +(Saturation instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var saturation = new Saturation(newValue, instance.type);
            // возвращаем результат
            return saturation;
        }
        public static Saturation operator +(double number, Saturation instance)
        {
            return instance + number;
        }
        public static Saturation operator -(Saturation instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value - number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var saturation = new Saturation(newValue, instance.type);
            // возвращаем результат
            return saturation;
        }
        public static Saturation operator -(double number, Saturation instance)
        {
            return instance - number;
        }

        public Saturation To(SaturationType newType)
        {
            var newValue = this.value;
            if (this.type == SaturationType.prcnt)
            {
                switch (newType)
                {
                    case SaturationType.thng:
                        newValue = this.value / 100;
                        break;
                }
            }
            else
            {
                switch (this.type)
                {
                    case SaturationType.thng:
                        newValue = this.value * 100;
                        break;
                }
            }
            return new Saturation(newValue, newType);
        }
    }
}
