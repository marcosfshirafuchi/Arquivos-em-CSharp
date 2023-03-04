using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, senha;
            Console.WriteLine("Digite o login: ");
            login = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();

            if(login =="Admin" && senha == "123") 
            {
                Console.WriteLine("Login foi bem sucedido!");
            }
            else
            {
                Console.WriteLine("Login falhou!");
            }
            Console.ReadLine();
        }
    }
}
