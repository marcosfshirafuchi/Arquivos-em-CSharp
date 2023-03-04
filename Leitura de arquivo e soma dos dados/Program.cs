using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_de_arquivo_e_soma_dos_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\famil\Documents\numeros.txt";
            StreamReader sr = new StreamReader(caminhoArquivo);

            int soma = 0;
            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
                //soma = soma + (int.Parse(linha));
                soma += (int.Parse(linha));
            }

            sr.Close();

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.ReadLine();
        }
    }
}
