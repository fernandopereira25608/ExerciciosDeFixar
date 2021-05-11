using System;

namespace Exercicios_Fixação_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de 10 pessoas!");
            string[] nomes = new string [10];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° nome");
                nomes[i] = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Digite o nome que deseja buscar");
            string nomeBuscar = Console.ReadLine().ToLower();

            bool encontrado = false;

            foreach (var cadaNome in nomes)
            {
                if (nomeBuscar == cadaNome)
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = false;
                }
            }
             if (encontrado == true)
                {
                    Console.WriteLine("Achei seu nome!!!");
                }
                else
                {
                    Console.WriteLine("Não achei seu nome!!!");
                }
        }
    }
}
