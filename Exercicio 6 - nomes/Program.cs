using System;

namespace Exercicio_6___nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            var search = false;

            Console.WriteLine("Digite 10 nomes");
            
            for (var i = 0; i < 10; i++)
            {
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.Write("Que nome deseja procurar? ");
            string procurado = Console.ReadLine().ToLower();

            foreach (string nome in nomes)
            {
                if (nome == procurado){
                    search = true;
                }
            }

            if (search == true){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ACHEI");
                Console.ResetColor();
            } else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NÃO ACHEI");
                Console.ResetColor();
            }

            
        }
    }
}
