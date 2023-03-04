using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10, B = 20, C = 0;
            C = A;
            A = B;
            B = C;
            Console.WriteLine("O novo valor da variável A é: " + A);
            Console.WriteLine("O novo valor da variável B é: " + B);
            Console.ReadLine();
        }
    }
}
