using System;

namespace Exercicios_Fixação_2
{
    class Program
    {
        static void Main(string[] args)

        {
            double descontoA1 = 4.9 * 0.96;
            double descontoA2 = 4.9 * 0.94;

            double descontoG1 = 5.3 * 0.97;
            double descontoG2 = 5.3 * 0.95;


            Console.WriteLine("Digite o tipo de Combustivel, A=Alcool e G=Gasolina: ");
            string Combustivel = Console.ReadLine().ToLower();

            Console.WriteLine("Quantos litros você quer abastecer?");
            int litros = int.Parse(Console.ReadLine());

            if (Combustivel == "a")
            {
                Console.WriteLine("O Combustivel escolhido foi o Alcool = 4,90");

                if (litros <= 20)
                {
                 double valorTotal = litros * descontoA1;
                 Console.WriteLine("")
                } else{
                 double valorTotal = litros * descontoA2;

                }
            }


            if (Combustivel == "G" || Combustivel == "g")
            {
                Console.WriteLine("O Combustivel escolhido foi Gasolina = 5,30");
            }

            if (litros <= 20)
            {

                descontoG1 = litros * 5.3;

            }

        }

    }
}
