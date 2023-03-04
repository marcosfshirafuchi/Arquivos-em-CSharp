using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
			int diaSemana = 3;
			string nomeDia;

			Console.WriteLine("Digite o dia da semana: ");
			diaSemana = Convert.ToInt32(Console.ReadLine());

			switch (diaSemana)
			{
				case 1:
					nomeDia = "Domingo";
					break; 
				case 2:
					nomeDia = "Segunda-feira";
					break;
				case 3:
					nomeDia = "Terça-feira";
					break;

				case 4:
					nomeDia = "Quarta-feira";
					break;

				case 5:
					nomeDia = "Quinta-feira";
					break;

				case 6:
					nomeDia = "Sexta-feira";
					break;

				case 7:
					nomeDia = "Sabado";
					break;

				default:
					nomeDia = "Dia invalido";
					break;

			}
			Console.WriteLine(nomeDia);
			Console.ReadLine();
		}
    }
}
