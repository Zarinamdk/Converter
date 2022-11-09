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
                    Value = Math.Round(Value / 0.000001, 6);
                    break;
                case "Литр":
                    Value = Math.Round(Value * 1000, 6);
                    break;
                case "Кубический_сантиметр":
                    Value = Math.Round(Value * 1000000, 6);
                    break;
                case "Кубический_дециметр":
                    Value = Math.Round(Value * 1000, 6);
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
                    Value = Math.Round(Value * 0.000001, 6);
                    break;
                case "Литр":
                    Value = Math.Round(Value / 1000, 6);
                    break;
                case "Кубический_сантиметр":
                    Value = Math.Round(Value / 1000000, 6);
                    break;
                case "Кубический_дециметр":
                    Value = Math.Round(Value / 1000, 6);
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}

