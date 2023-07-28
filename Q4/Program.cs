using System;

namespace NumerosIntervalo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Loop para imprimir os números inteiros no intervalo
            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
