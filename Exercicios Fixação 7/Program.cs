using System;

namespace Exercicios_Fixação_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 15 numeros!");

            int[] numeros = new int [3];

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (var i = (numeros.Length - 1); i >= 0; i--)
            {
                Console.WriteLine($"\n{numeros[i]}");
            }


        }
    }
}
