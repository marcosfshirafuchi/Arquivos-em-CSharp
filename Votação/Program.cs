using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votação
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            

            if (idade >= 18)
            {
                Console.WriteLine("O usuário esta apto para votar!");
            }
            else
            {
                Console.WriteLine("O usuário não esta apto para votar!");
            }
            Console.ReadLine();
        }
    }
}
