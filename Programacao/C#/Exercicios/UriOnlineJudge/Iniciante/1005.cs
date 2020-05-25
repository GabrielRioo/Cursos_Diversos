using System;
using System.Globalization;

namespace Uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3.5;
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 7.5;

            MEDIA = (A + B) / 11.0;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
        }
    }
}
