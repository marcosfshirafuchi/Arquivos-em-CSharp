using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_da_circunferencia
{
    class Program
    {
        const double pi = 3.14159;
        static void Main(string[] args)
        {
            double raio = 5.0;
            double area = pi * raio * raio;

            Console.WriteLine("A área do circulo é : " + area);
            Console.ReadLine();
        }
    }
}
