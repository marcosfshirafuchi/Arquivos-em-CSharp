using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            string z = "";

            if (x > y && y < 3)
            {
                z = "primeiro";
            }
            else if (x < y || x == 5)
            {
                z = "segundo";
            }
            else if (x == y)
            {
                z = "terceiro";
            }
            else if (x > y)
            {
                z = "quarto";
            }
            else
            {
                z = "quinto";
            }
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
