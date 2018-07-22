using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public static class Utility
    {

        public static UserInput GetUserInput()
        {

            //Get input temperature unit from the user
            Console.WriteLine("Please enter the INPUT temperature unit(1 for Celcius, 2 for Fahrenheit, 3 for Kelvin, 4 for Rankine) : ");
            int selectionInput = 0;

            while (!int.TryParse(Console.ReadLine(), out selectionInput))
            {
                Console.WriteLine("You entered an INVALID value.Please enter a valid numerical value!");
                Console.WriteLine("Please enter the input temperature unit(1 for Celcius, 2 for Fahrenheit, 3 for Kelvin, 4 for Rankine) : ");
            }



            //Get input temperature value from the user
            Console.WriteLine("Please enter the INPUT temperature value: ");
            double inputTemperatureVal = 0.0;

            while (!double.TryParse(Console.ReadLine(), out inputTemperatureVal))
            {
                Console.WriteLine("You entered an INVALID value.Please enter a valid numerical value!");
                Console.WriteLine("Please enter the INPUT temperature value: ");
            }


            //Get output temperature unit from the user
            Console.WriteLine("Please enter the OUTPUT temperature unit(1 for Celcius, 2 for Fahrenheit, 3 for Kelvin, 4 for Rankine) : ");
            int selectionOutput = 0;

            while (!int.TryParse(Console.ReadLine(), out selectionOutput))
            {
                Console.WriteLine("You entered an INVALID value.Please enter a valid numerical value!");
                Console.WriteLine("Please enter the output temperature unit(1 for Celcius, 2 for Fahrenheit, 3 for Kelvin, 4 for Rankine) : ");
            }


            //Get student temperature value from the user
            Console.WriteLine("Please enter the STUDENT temperature value: ");
            double responseTemperatureVal = 0.0;

            while (!double.TryParse(Console.ReadLine(), out responseTemperatureVal))
            {
                Console.WriteLine("You entered an INVALID value.Please enter a valid numerical value!");
                Console.WriteLine("Please enter the STUDENT temperature value: ");
            }


            UserInput u =  new UserInput();            
            u.SelectionInput = selectionInput;
            u.InputTemperatureVal = inputTemperatureVal;
            u.SelectionOutput = selectionOutput;
            u.ResponseTemperatureVal = responseTemperatureVal;

            return u;
        }



        public static double GetTemperatureValue(int selection, Temperature resultTemperature)
        {

            double resultTemperatureVal=0.0;

            switch ((TemperatureType)selection)
            {
                case TemperatureType.Celsius:
                    resultTemperatureVal = resultTemperature.Celsius;
                    break;
                case TemperatureType.Fahrenheit:
                    resultTemperatureVal = resultTemperature.Fahrenheit;
                    break;
                case TemperatureType.Kelvin:
                    resultTemperatureVal = resultTemperature.Kelvin;
                    break;
                case TemperatureType.Rankine:
                    resultTemperatureVal = resultTemperature.Rankine;
                    break;

            }

            return resultTemperatureVal;

        }


    public static double GetTemperature (int selectionInput, double inputTemperatureValue, int selectionOutput)
        {

            var resultTemperature = new Temperature();
            double resultTemperatureVal = 0.0;

            switch ((TemperatureType)selectionInput)
            {
                case TemperatureType.Celsius:
                    resultTemperature = Temperature.FromCelsius(Convert.ToDouble(inputTemperatureValue));
                    break;
                case TemperatureType.Fahrenheit:
                    resultTemperature = Temperature.FromFahrenheit(Convert.ToDouble(inputTemperatureValue));
                    break;
                case TemperatureType.Kelvin:
                    resultTemperature = Temperature.FromKelvin(Convert.ToDouble(inputTemperatureValue));
                    break;
                case TemperatureType.Rankine:
                    resultTemperature = Temperature.FromRankine(Convert.ToDouble(inputTemperatureValue));
                    break;

            }

            resultTemperatureVal = GetTemperatureValue(selectionOutput, resultTemperature);

            return resultTemperatureVal;
        }


    }
}
