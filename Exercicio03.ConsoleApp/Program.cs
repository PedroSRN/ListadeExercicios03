using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        /*Exercício 3:
        • Desenvolver um algoritmo que efetue a soma de todos os números 
        ímpares que são múltiplos de três e que se encontram no conjunto dos 
        números de 1 até 500*/
        static void Main(string[] args)

        {
            int num, soma;
            num = 0;
            soma = 0;

            for (num = 1; num <= 500; num++)
            {
                if (num % 3 == 0)
                {
                    soma = soma = num;
                }
            }

            Console.WriteLine("O resultado da soma dos numeros impares  multiplos de 3 foi de: " + soma);
            Console.ReadLine();

        }
    }
}
