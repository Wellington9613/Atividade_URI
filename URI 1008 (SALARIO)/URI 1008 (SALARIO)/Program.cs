using System;
using System.Globalization;

namespace uri_1006
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, horas;
            double valor;
            Console.WriteLine("Digite seu numero: ");
            number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o tanto de horas: ");
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor das suas horas: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));










        }
    }

}