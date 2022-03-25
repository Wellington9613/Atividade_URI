using System;
using System.Globalization;

namespace uri_1005
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2,media;
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {media.ToString("F5")}");

        }
    }

}