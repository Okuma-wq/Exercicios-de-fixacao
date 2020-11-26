using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo = "";
            double litros;
            

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Seja Bem-Vindo!");
            Console.WriteLine("--------------------------------------------------------------------------");
            do{
                Console.WriteLine("Que tipo de combustível deseja comprar? (A para álcool e G para gasolina)");
                tipo = Console.ReadLine().ToUpper();
                
                if (tipo != "A" && tipo != "G")
                {
                    Console.WriteLine("Tipo de combustivel digitado inválido");
                }
            } while(tipo != "A" && tipo != "G");

            Console.WriteLine("Quantos litros deseja comprar?");
            while(!double.TryParse(Console.ReadLine(), out litros));
            Console.WriteLine("--------------------------------------------------------------------------");
            
            double custo = 0;
            
            double G(double litros){
                if (litros <= 20)
                {
                    custo = litros * (5.30 - (5.30 * 0.03));    
                } else{
                custo = litros * (5.30 - (5.30 * 5/100));    
                }
                return custo;
            }

            double A(double litros){
                if (litros <= 20)
                {
                custo = litros * (4.90 - (4.90 * 4/100));       
                } else{
                custo = litros * (4.90 - (4.90 * 6/100));                    
                }
                return custo;
            }

            switch (tipo)
            {
                case "G":
                    G(litros);                   
                    break;
                case "A":
                        A(litros);
                    break;
                default:
                    Console.WriteLine("Tipo de combustivel inválido");
                    break;
            }
            
            Console.WriteLine("O preço a ser pago é de " + custo.ToString("C"));
            
            
        }
    }
}
