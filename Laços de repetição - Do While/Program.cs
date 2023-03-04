using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_de_repetição___Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do {

                Console.WriteLine("O valor de i é: " + i);
                i++;
            } while(i<10);
            Console.ReadLine();
        }
    }
}
