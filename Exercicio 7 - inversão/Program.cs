using System;

namespace Exercicio_7___inversão
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[15];

            Console.WriteLine("Digite 15 números");
            for (var i = 0; i <= 14; i++){
                numeros[i] = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("--------------------------------");

            Array.Reverse(numeros);

            Console.WriteLine("Sua lista invertida:");
            for (var i = 0; i <= 14; i++){
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("--------------------------------");


        }
    }
}
