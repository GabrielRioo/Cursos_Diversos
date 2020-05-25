using System;
using System.Globalization;
namespace Uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 2.0;
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3.0;
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 5.0;

            MEDIA = (A + B + C)/10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
        }
    }
}
