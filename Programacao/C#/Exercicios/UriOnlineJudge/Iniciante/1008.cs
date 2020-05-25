using System;
using System.Globalization;
namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, HoraTrab;
            double ValorHora, Salario;

            Num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            HoraTrab = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = HoraTrab * ValorHora;

            Console.WriteLine("NUMBER = " + Num);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"));


        }
    }
}
