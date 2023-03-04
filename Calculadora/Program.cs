using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, media, soma, subtracao, multiplicacao, divisao;
            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            media = (numero1 + numero2) / 2;
            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;

            if (numero2 == 0)
            {
                Console.WriteLine("Coloque um numero diferente de Zero");
                Console.WriteLine("Digite o segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A media entre " + numero1 + " e " + numero2 + " = " + media);
                Console.WriteLine("A soma entre " + numero1 + " e " + numero2 + " = " + soma);
                Console.WriteLine("A subtração entre " + numero1 + " e " + numero2 + " = " + subtracao);
                Console.WriteLine("A multiplicação entre " + numero1 + " e " + numero2 + " = " + multiplicacao);
                Console.WriteLine("A divisão entre " + numero1 + " e " + numero2 + " = " + divisao);
            }
            else
            {
                Console.WriteLine("A media entre " + numero1 + " e " + numero2 + " = " + media);
                Console.WriteLine("A soma entre " + numero1 + " e " + numero2 + " = " + soma);
                Console.WriteLine("A subtração entre " + numero1 + " e " + numero2 + " = " + subtracao);
                Console.WriteLine("A multiplicação entre " + numero1 + " e " + numero2 + " = " + multiplicacao);
                Console.WriteLine("A divisão entre " + numero1 + " e " + numero2 + " = " + divisao);
                Console.ReadLine();
            }
        }
    }
}
