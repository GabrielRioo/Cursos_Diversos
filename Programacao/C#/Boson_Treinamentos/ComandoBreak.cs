using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            while (true)
            {
                Console.WriteLine("Digite um numero: ");
                i = int.Parse(Console.ReadLine());
                if (i == 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("O numero digitado foi: " + i);
                }
                
            }
            Console.WriteLine("Mensagem após o loop final");
        }
    }
}
