using System;

namespace Exercicios_Fixação_3
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quanto(as) " + nome + " Você esta comprando?");
            int qnt = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite o preço unitário: ");
            double preçoUnit = int.Parse( Console.ReadLine());

            double preço = qnt * preçoUnit;

            if ( qnt<=5 )
            {
            double preçoTotal = preço * 0.98;
            Console.WriteLine("Você pagará R$" + preçoTotal);
            }

           else if (qnt > 5 && qnt <=10)
           {
            double preçoTotal = preço * 0.97;
            Console.WriteLine("Você pagará R$" + preçoTotal);

           }

           else if (qnt > 10)
           {
            double preçoTotal = preço * 0.95;
            Console.WriteLine("Você pagará R$" + preçoTotal);
           }
          
      
        }
    }
}
