using System;

namespace Exercicios_Fixação_1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Digite em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o ano atual?");
            // int anoAtual = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNascimento;


            if (idade >= 16)
            {
                Console.WriteLine("Você pode votar");
            }

            else 
            {
                Console.WriteLine("Você não pode votar!");
            }

        }

    
    }
}
