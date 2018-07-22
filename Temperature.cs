using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{



    public struct UserInput
    {
        public int SelectionInput;
        public double InputTemperatureVal;
        public int SelectionOutput;
        public double ResponseTemperatureVal;
    }


    public class Temperature
    {
       

        private double _fahrenheit=0.0;

        public double Fahrenheit
        {
            get
            {
                return _fahrenheit;
            }
            set
            {
                _fahrenheit = value;
            }
        }

        public double Celsius
        {
            get
            {
                return (Fahrenheit -32.0) * (5.0/9.0);
            }
            set
            {
                Fahrenheit = ((value * 9.0) / 5.0 ) + 32.0;
            }
        }

        public double Kelvin
        {
            get
            {
                return   (Fahrenheit + 459.67) * (5.0 / 9.0);
            }
            set
            {
                Fahrenheit = (value * 9.0 / 5.0) - 459.67;
            }
        }

        public double Rankine
        {
            get
            {
                return Fahrenheit + 459.67;
            }
            set
            {
                Fahrenheit = value - 459.67;
            }
        }


        public static Temperature FromCelsius(double celsius)
        {
            var temperature = new Temperature();
            temperature.Celsius = celsius;
            return temperature;
        }

        public static Temperature FromFahrenheit(double fahrenheit)
        {
            var temperature = new Temperature();
            temperature.Fahrenheit = fahrenheit;
            return temperature;
        }
        public static Temperature FromKelvin(double kelvin)
        {
            var temperature = new Temperature();
            temperature.Kelvin = kelvin;
            return temperature;
        }

        public static Temperature FromRankine(double rankine)
        {
            var temperature = new Temperature();
            temperature.Rankine = rankine;
            return temperature;
        }





    }
}
