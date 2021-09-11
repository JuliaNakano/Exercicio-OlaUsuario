using System;

namespace Exercicio_OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomedousuário;
            Console.Write("Digite seu nome: ");
            nomedousuário= Console.ReadLine();

            Console.WriteLine($"Olá {nomedousuário}!");
        }
    }
}
