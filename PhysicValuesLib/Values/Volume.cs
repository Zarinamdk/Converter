using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class Volume : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Объем";

        private List<string> _measureList = new List<string>()
        {
           "Милилитр",
            "Литр",
            "Кубический сантиметр",
            "Кубический дециметр",
            "Кубический метр"
        };

        /// <summary>
        /// Метод возвращает конвертированное значение
        /// </summary>
        /// <returns></returns>
        public double GetConvertedValue(double value, string from, string to)
        {
            Value = value;
            From = from;
            To = to;

            ToSi();
            ToRequired();
            return Value;
        }

        /// <summary>
        /// Метод возвращает список единиц измерения
        /// </summary>
        /// <returns></returns>
        public List<string> GetMeasureList()
        {
            return _measureList;
        }

        /// <summary>
        /// Метод конвертирует в нужные единицы измерения
        /// </summary>
        public void ToRequired()
        {
            switch (To)
            {
                case "Кубический_метр":
                    break;
                case "Милилитр":
                    Value /= 0.000001;
                    break;
                case "Литр":
                    Value *= 1000;
                    break;
                case "Кубический_сантиметр":
                    Value *= 1000000;
                    break;
                case "Кубический_дециметр":
                    Value *= 1000;
                    break;
            }
        }

        /// <summary>
        /// Метод переводит в систему СИ
        /// </summary>
        public void ToSi()
        {
            switch (From)
            {
                case "Кубический_метр":
                    break;
                case "Милилитр":
                    Value *= 0.000001;
                    break;
                case "Литр":
                    Value /= 1000;
                    break;
                case "Кубический_сантиметр":
                    Value /= 1000000;
                    break;
                case "Кубический_дециметр":
                    Value /= 1000;
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}

