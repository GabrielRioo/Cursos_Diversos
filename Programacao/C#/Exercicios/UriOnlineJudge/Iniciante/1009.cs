using System;
using System.Globalization;
namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo, totalVendas, comissao, totalSalario;

            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = totalVendas * 0.15;

            totalSalario = comissao + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + totalSalario.ToString("F2"));

            


        }
    }
}
