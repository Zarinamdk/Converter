using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    class Speed:IValue
    {
        private List<string> _meassureList = new List<string>()
        {
            "Метр в секунду",
            "Метр в минуту",
            "Километр в секунду",
            "Километр в час"       
        };
        private double _value;
        private string _from;
        private string _to;
        public double GetConvertedValue(double value, string from, string to)
        {
            // проверка
            if (_value >= 0)
            {
                _value = value;
                _from = from;
                _to = to;
                ToSI();
                ToRequired();
                return _value;
            }
            else
            {
                throw new NotImplementedException("Недопустимое значение");
            }
        }
        public List<string> GetMeassureList()
        {
            return _meassureList;
        }
        /// <summary>
        /// метод преобразования в си
        /// </summary>
        public void ToSI()
        {
            switch (_from)
            {
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    _value = _value * 1000 / 3600;
                    break;
                case "Метр в минуту":
                    _value /= 60;
                    break;
                case "Километр в секунду":
                    _value *= 1000;
                    break;
            }
        }
        /// <summary>
        /// метод преобразования в си
        /// </summary>
        public void ToRequired()
        {
            switch (_to)
            {
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    _value = _value / 1000 * 3600;
                    break;
                case "Метр в минуту":
                    _value *= 60;
                    break;
                case "Километр в секунду":
                    _value /= 1000;
                    break;
            }
        }
    }
}
