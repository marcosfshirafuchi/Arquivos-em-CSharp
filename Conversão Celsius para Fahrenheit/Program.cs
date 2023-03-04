using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Celsius_para_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit;
            Console.WriteLine("Digite a temperatura em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());
            Fahrenheit = (Celsius * 1.8) + 32;
            Console.WriteLine("A temperatura de " + Celsius + " Celsius para Fahrenheit = " + Fahrenheit);
            Console.ReadLine();
        }
    }
}
