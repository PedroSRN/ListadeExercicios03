using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        /*Exercício 5:
        • Escreva um algoritmo que leia um valor inicial A e imprima a sequência de 
        valores do cálculo de A! e o seu resultado. 
        Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        • Pesquise sobre “fatorial”*/

        static void Main(string[] args)
        {
            int num = 0;
            int i = 0;

            Console.WriteLine("Digite o numero na qual quer imprimir sua sequência: ");
            num = Convert.ToInt32(Console.ReadLine());

            
                for (i = num - 1; i >= 1; i--)
                {
                    num = num * i;
                    Console.WriteLine(num + "! = " + i);
                }
            

            Console.WriteLine("-------");
            Console.WriteLine(i * num);
            Console.ReadLine();
        }
    }
}
