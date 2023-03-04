using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_repetição___While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10) 
            {
                Console.WriteLine("O valor de i é: " + i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
