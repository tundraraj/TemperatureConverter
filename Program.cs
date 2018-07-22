using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {


            //Initialize temperature class / value variables
            var resultTemperature = new Temperature();
            double resultTemperatureValue = 0.0;


            //Get input from user
            UserInput u = Utility.GetUserInput();


            //Get output temperature value based on the user choice
            resultTemperatureValue = Utility.GetTemperature(u.SelectionInput,u.InputTemperatureVal,u.SelectionOutput);


            //Compare actual response vs Student response
            if (Math.Round(resultTemperatureValue, 1) == Math.Round(u.ResponseTemperatureVal, 1))
            {
                Console.WriteLine("Student response ({0}) is CORRECT ",u.ResponseTemperatureVal);
            }
            else
            {
                Console.WriteLine("Student response ({0}) is INCORRECT ", u.ResponseTemperatureVal);
                Console.WriteLine("Correct response  is {0}  ", Math.Round(resultTemperatureValue, 1));
            }
             
                

            //exit program
            Console.WriteLine("\nPlease enter any key to exit");
            Console.ReadLine();
        }
    }
}
