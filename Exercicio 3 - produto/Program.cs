using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a quantidade adquirida: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço unitário: ");
            float preco = float.Parse(Console.ReadLine());
            
            Console.WriteLine("-------------------------------------------");

            float total = qtd * preco;
            float totalAPagar = 0;

            Console.WriteLine("Total de: " + total.ToString("C"));
            
            if (qtd <= 5)
            {
                totalAPagar = total - (total * 2/100);
                Console.WriteLine("Desconto de 2% na compra de até 5 produtos");
            }
            if (qtd > 5 && qtd <= 10)
            {
                totalAPagar = total - (total * 3/100);
                Console.WriteLine("Desconto de 3% na compra de até mais de 5 produtos");

            }
            if (qtd >10){
                totalAPagar = total - (total * 5/100);
                Console.WriteLine("Desconto de 5% na compra de até mais de 10 produtos");
            }

            Console.WriteLine("Total a pagar: " + totalAPagar.ToString("C"));

        }
    }
}
