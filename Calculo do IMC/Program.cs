using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_do_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc, peso, altura;
            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else 
            {
                Console.WriteLine("Obesidade grau 1");
            }
            Console.ReadLine();

        }
    }
}
