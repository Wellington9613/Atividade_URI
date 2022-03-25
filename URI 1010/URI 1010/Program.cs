using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        public static void Main(string[] args)
        {

            int cod, quantidade;
            int cod1, quantidade1;
            double valor, valor1, soma, soma1;

            String[] vet = Console.ReadLine().Split(' ');
            String[] vet2 = Console.ReadLine().Split(' ');

            cod = int.Parse(vet[0], CultureInfo.InvariantCulture);

            quantidade = int.Parse(vet[1], CultureInfo.InvariantCulture);

            valor = double.Parse(vet[2], CultureInfo.InvariantCulture);





            cod1 = int.Parse(vet2[0], CultureInfo.InvariantCulture);

            quantidade1 = int.Parse(vet2[1], CultureInfo.InvariantCulture);

            valor1 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            soma = quantidade * valor;
            soma1 = quantidade1 * valor1;

            double resultado = soma + soma1;
            Console.WriteLine("VALOR A PAGAR : R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}