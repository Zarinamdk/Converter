using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib
{
    class Volume: IValue
    {
        private List<string> _meassureList = new List<string>()
        {
            "Милилитр",
            "Литр",
            "Кубический сантиметр",
            "Кубический дециметр",
            "Кубический метр"
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

        public void ToSI()
        {
            // преобразовать в СИ
            switch (_from)
            {
                case "Кубический_метр":
                    break;
                case "Милилитр":
                    _value *= 0.000001;
                    break;
                case "Литр":
                    _value /= 1000;
                    break;
                case "Кубический_сантиметр":
                    _value /= 1000000;
                    break;
                case "Кубический_дециметр":
                    _value /= 1000;
                    break; 
            }
        }

        public void ToRequired()
        {
            switch (_to)
            {
              case "Кубический_метр":
                    break;
                case "Милилитр":
                    _value /= 0.000001;
                    break;
                case "Литр":
                    _value *= 1000;
                    break;
                case "Кубический_сантиметр":
                    _value *= 1000000;
                    break;
                case "Кубический_дециметр":
                    _value *= 1000;
                    break;
            }
        }
    }
}
