
using System;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente
            {
                Nome = "João",
                Email = "joao@email.com"
            };

            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Email válido? {cliente.EmailValido()}");
        }
    }
}
