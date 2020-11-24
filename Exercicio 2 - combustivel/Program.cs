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
            
            double G20litrosOuMenos(double litros){
                custo = litros * (5.30 - (5.30 * 3/100));
                return custo;
            }

            double GMaisDe20litros(double litros){
                custo = litros * (5.30 - (5.30 * 5/100));
                return custo;
            }

            double A20litrosOuMenos(double litros){
                custo = litros * (4.90 - (4.90 * 4/100));
                return custo;
            }

            double AMaisDe20litros(double litros){
                custo = litros * (4.90 - (4.90 * 6/100));
                return custo;
            }

            switch (tipo)
            {
                case "G":
                    if (litros <= 20)
                    {
                        G20litrosOuMenos(litros);
                    } else{
                        GMaisDe20litros(litros);
                    }
                    
                    break;
                case "A":
                    if (litros <= 20)
                    {
                        A20litrosOuMenos(litros);
                    } else{
                        AMaisDe20litros(litros);
                    }
                    break;
                default:
                    break;
            }
            
            Console.WriteLine("O preço a ser pago é de " + custo.ToString("C"));
            
            
        }
    }
}
