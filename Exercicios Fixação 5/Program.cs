using System;

namespace Exercicios_Fixação_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, contador;
            int tabs;

            for (tabs = 0; tabs <= 10; tabs++)
            {
                
                for ( contador = 0; contador <= 10; ++contador)
                {
                    formula = tabs * contador;
                    Console.WriteLine(tabs + " X " + contador + " = " + formula);
                }
            }
        }
    }
}
