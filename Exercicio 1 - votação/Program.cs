﻿using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Digite o ano atual: ");
            int atual = int.Parse(Console.ReadLine());
            Console.Write("Digite seu ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = 0;

            calcIdade(atual, nascimento);

            int calcIdade(int atual, int nascimento){
                idade = atual - nascimento;
                return idade;
            }

            if (idade >= 18)
            {
                Console.WriteLine("Será necessário votar esse ano.");
            } else{
                Console.WriteLine("Não será necessário votar esse ano.");
            }

        }
    }
}
