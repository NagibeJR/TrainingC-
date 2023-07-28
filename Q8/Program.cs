using System;
namespace Circulo
{
    class Circulo
    {
        private float raio;

        public Circulo(float raio)
        {
            this.raio = raio;
        }

        public float CalcularArea()
        {
            return (float)(3.14 * raio * raio);
        }

        public float CalcularComprimento()
        {
            return (float)(2 * 3.14 * raio);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o raio do círculo:");
            float raio = float.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(raio);

            float area = circulo.CalcularArea();
            float comprimento = circulo.CalcularComprimento();

            Console.WriteLine($"Área do círculo: {area}");
            Console.WriteLine($"Comprimento do círculo: {comprimento}");
        }
    }

}

