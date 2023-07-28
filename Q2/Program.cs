using System;

namespace Operacoes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            float soma = num1 + num2;
            float sub = num1 - num2;
            float resto = num1 % num2;
            float divisao = num1 / num2;
            float multi = num1 * num2;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {sub}");
            Console.WriteLine($"Resto: {resto}");
            Console.WriteLine($"Divisão: {divisao}");
            Console.WriteLine($"Multiplicação: {multi}");
        }
    }
}
