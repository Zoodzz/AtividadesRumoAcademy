using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPositivo = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Digite o " + i + "º número :");

                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    numPositivo++;
                    Console.WriteLine("Número positivo encontrado: " + numero);
                }
            }

            Console.WriteLine("\nTotal de números positivos encontrados: " + numPositivo);
        }
    }
}
