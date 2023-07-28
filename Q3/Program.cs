using System;

namespace NumeroIntervalo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 100)
                {
                    Console.WriteLine("O número está dentro do intervalo entre 10 e 100.");
                }
                else
                {
                    Console.WriteLine("O número está fora do intervalo entre 10 e 100.");
                }
        }
    }
}
