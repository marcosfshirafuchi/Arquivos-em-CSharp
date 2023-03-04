using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_Matemática
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            int num1, num2;
            Console.WriteLine("Operação matemática: \nSoma: + \nSubtração: - \nMultiplicação: *  \nDivisão: /");
            Console.Write("Digite uma das opções acima: ");
            operacao = Console.ReadLine();
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if (operacao == "/" && num2 == 0)
            {
                Console.WriteLine("O segundo número tem que ser diferente de zero: ");
                do
                {
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = int.Parse(Console.ReadLine());
                } while (num2 == 0);

                
                if (operacao == "+")
                {
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                }
                if (operacao == "-")
                {
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                }
                if (operacao == "-")
                {
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                }
                else if (operacao == "/")
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                }
            }
            else
            {
                if (operacao == "+") 
                {
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                }
                if (operacao == "-")
                {
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                }
                if (operacao == "-")
                {
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                }
                else if (operacao == "/")
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                }
                
            }
            Console.ReadLine();
        }
    }
}
