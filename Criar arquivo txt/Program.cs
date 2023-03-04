using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criar_arquivo_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroLinhas;
            // Entrada
            Console.WriteLine("Informe a quantidade de linhas a serem escritas: ");
            numeroLinhas = int.Parse(Console.ReadLine());

            StreamWriter sw = new StreamWriter(@"C:\Users\famil\Documents\numeros.txt");

            // Processamento
            for (int i = 1; i <= numeroLinhas; i++)
            {
                sw.WriteLine(i);
            }

            sw.Close();

            // Saída
            Console.WriteLine("Arquivo escrito");
            Console.ReadLine();
        }
    }
}
