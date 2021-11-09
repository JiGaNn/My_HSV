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
        public static Value operator +(Value instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var value = new Value(newValue, instance.type);
            // возвращаем результат
            return value;
        }
        public static Value operator +(double number, Value instance)
        {
            return instance + number;
        }
        public static Value operator -(Value instance, double number)
        {
            // расчитываем новoe значение
            var newValue = instance.value - number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var value = new Value(newValue, instance.type);
            // возвращаем результат
            return value;
        }
        public static Value operator -(double number, Value instance)
        {
            return instance - number;
        }

        public Value To(ValueType newType)
        {
            var newValue = this.value;
            if (this.type == ValueType.prcnt)
            {
                switch (newType)
                {
                    case ValueType.thng:
                        newValue = this.value / 100;
                        break;
                }
            }
            else
            {
                switch (this.type)
                {
                    case ValueType.thng:
                        newValue = this.value * 100;
                        break;
                }
            }
            return new Value(newValue, newType);
        }
    }
}
