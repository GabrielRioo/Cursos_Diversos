using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;
            string nome;
            Console.WriteLine("Digite o dia da semana, de 1 a 7: ");
            diaSemana = int.Parse(Console.ReadLine());

            switch (diaSemana)
            {
                case 1:
                    nome = "Domingo";
                    break;
                case 2:
                    nome = "Segunda";
                    break;
                case 3:
                    nome = "Terça";
                    break;
                case 4:
                    nome = "Quarta";
                    break;
                case 5:
                    nome = "Quinta";
                    break;
                case 6:
                    nome = "Sexta";
                    break;
                case 7:
                    nome = "Sabado";
                    break;
                default:
                    nome = "Dia Invalido";
                    break;
            }
            Console.WriteLine("O dia da semana é: " + nome);
        }
    }
}
