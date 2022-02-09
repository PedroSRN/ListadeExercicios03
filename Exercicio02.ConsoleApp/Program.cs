using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        /*Exercício 2:
            • Escrever um algoritmo que gera e escreve os números ímpares entre 100 
            e 200.*/
        static void Main(string[] args)
        {
            for (int i = 100; i < 201; i++) 
            {
              if((i% 2 != 0))
                {
                    Console.WriteLine("Os numeros impares de 100 a 200 são: " + i);
                }
            }

            Console.ReadLine();
        }
    }
}
