using System;

namespace Exercicio_5___tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Imprimindo tabuada do 1 ao 10");

            while (contador <= 9){
                contador++;
                Console.WriteLine($"Tabuada do {contador}");

                for (var n = 0; n<= 10; n++)
                {
                    int resultado = contador * n;
                    Console.WriteLine($"{contador} X {n} = {resultado}");
                    
                }
            }
        }
    }
}
