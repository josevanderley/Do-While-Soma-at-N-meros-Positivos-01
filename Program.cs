using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do__While__Soma_até_Números_Positivos_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************BEM VINDO AO PROGRAMA****************");

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            int numero;
            int soma = 0;

            do
            {
                Console.Write("Insira um número inteiro positivo (insira um número negativo para encerrar): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    soma += numero;
                }

            } while (numero >= 0);

            Console.WriteLine($"A soma dos números positivos inseridos é: {soma}");
        }
    }
}
        
