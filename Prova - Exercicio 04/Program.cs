using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 20;

            if (x < 15 && y > 15)
            {
                Console.WriteLine("x é menor que 15 e y é maior que 15");
            }
            else if (x > 15 && y < 15)
            {
                Console.WriteLine("x é maior que 15 e y é menor que 15");
            }
            else
            {
                Console.WriteLine("x e y são ambos maiores ou iguais a 15");
            }
            Console.ReadLine();
        }
    }
}
