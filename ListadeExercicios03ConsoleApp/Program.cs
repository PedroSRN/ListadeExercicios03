using System;

namespace ListadeExercicios03ConsoleApp
{
    internal class Program
    {
        /*
         Exercício 1:
            • Desenvolver um algoritmo que leia a altura de 15 pessoas. Este 
            programa deverá calcular e mostrar:
            a. A menor altura do grupo;
            b. A maior altura do grupo;
         */


        
        static void Main(string[] args)
        {
            int i = 0;
            double altura, maior, menor; 
            

            Console.WriteLine("Digite sua altura: ");
            altura= Convert.ToDouble(Console.ReadLine());

            maior = altura;
            menor = altura;
            i = 1;
            for ( i = 2; i <= 15; i++)
            {
               
                Console.WriteLine("as alturas são altura: " +    Convert.ToDouble(altura++));
                if (altura > maior)
                {
                    maior = altura;
                }

                if (altura < menor)
                {
                    menor = altura;
                }
                
            }
            Console.WriteLine("A maior altura é: " + maior);
            Console.WriteLine("A menor altura é: " + menor);

            Console.ReadLine();

        }
    }
}
