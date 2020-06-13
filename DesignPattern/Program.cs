using DesignPattern.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    double F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;
                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    double C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            Console.ReadLine();
        }
    }
}