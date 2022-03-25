using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        public static void Main(string[] args)
        {

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo,pi = 3.14159;
            //VETOR 
            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);

            b = double.Parse(vet[1], CultureInfo.InvariantCulture);

            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = (a * c) / 2;
            quadrado = b * b;
            retangulo = a * b;
            trapezio = (a + b) * c / 2;
            circulo = (c * c) * pi;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));







        }
    }
}