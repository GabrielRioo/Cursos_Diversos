using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Escreva algo. Escreva 'exit' para finalizar");
            nome = Console.ReadLine();

            while (nome != "exit")
            {
                Console.WriteLine("Escreva algo. Escreva 'exit' para finalizar");
                nome = Console.ReadLine();
                
            }
        }
    }
}
