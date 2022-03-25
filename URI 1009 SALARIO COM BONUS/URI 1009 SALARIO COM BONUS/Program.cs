using System;
using System.Globalization;

namespace uri_1009
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome_vendedor;
            double salario, comissao;

            nome_vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double renda = comissao * 15.0 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + renda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("QUER SABER VALOR TOTAL DA COMISSÃO??");
            
            string ver_comissao = "sim";
            ver_comissao = Console.ReadLine();
            if (ver_comissao == "sim")
            {
                Console.WriteLine("O valor é: " + comissao * 15.0 / 100);
            }
            else
            {
                Console.WriteLine("Obrigado");
            }

                    

           






        }
    }

}