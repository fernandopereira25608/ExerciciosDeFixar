using System;

namespace Exercicios_Fixação_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 valores!");
            int[] numeros = new int[10];

            for (var i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine($"O menor numero é: {numeros[0]} ");
            Console.WriteLine($"O maior numero é: {numeros[9]} ");
        }
    }
}