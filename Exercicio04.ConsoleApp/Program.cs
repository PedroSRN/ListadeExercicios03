using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        /*  Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e 
            calcule a tabuada de N.
            • Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.*/
        static void Main(string[] args)
        {
            int num;
            int i = 0;
            Console.WriteLine("Digite um numero para saber sua tabuada: ");
            i = Convert.ToInt32(Console.ReadLine());
            
            
            for(num = 1; num <= 10; num++)
            {
                Console.WriteLine(i + "x" + num + "  : "+ num * i);
            }
           
            Console.ReadLine();
        }
    }
}
