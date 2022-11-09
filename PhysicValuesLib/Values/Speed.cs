using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class Speed : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Скорость";

        private List<string> _measureList = new List<string>()
        {
            "Метр в секунду",
            "Метр в минуту",
            "Километр в секунду",
            "Километр в час"
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
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    Value = Math.Round(Value / 1000 * 3600, 6);
                    break;
                case "Метр в минуту":
                    Value = Math.Round(Value * 60, 6);
                    break;
                case "Километр в секунду":
                    Value = Math.Round(Value / 1000, 6);
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
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    Value = Math.Round(Value * 1000 / 3600, 6);
                    break;
                case "Метр в минуту":
                    Value = Math.Round(Value / 60, 6);
                    break;
                case "Километр в секунду":
                    Value = Math.Round(Value * 1000, 6);
                    break;
            }
        }

        public string GetValueName()
        {
            return _valueName;
        }
    }
}
