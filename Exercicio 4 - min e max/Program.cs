using System;

namespace Exercicio_4___min_e_max
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double [10];
            double maior = 0;
            double menor = 1000000000000;

            
            Console.WriteLine("Digite dez valores:");
            for (var i = 0; i < 10; i++)
            {
                valores[i] = double.Parse(Console.ReadLine());
                if (valores[i] > maior)
                {
                    maior = valores[i];
                }
                if (valores[i] < menor){
                    menor = valores[i];
                }
            }


            Console.Write("O menor valor digitado foi ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(menor);
            Console.ResetColor();
            Console.Write(" e o maior valor digitado foi ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(maior);
            Console.ResetColor();
        }
    }
}
