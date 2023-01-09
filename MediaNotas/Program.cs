using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double somatorionotas = 0;

            int resultadonotas = 0;

            while (true)
            {
                Console.WriteLine("Digite a nota da prova (digite um número negativo para sair):");

                double nota = double.Parse(Console.ReadLine());

                if (nota < 0)
                {

                    break;
                }

                somatorionotas += nota;
                resultadonotas++;
            }

            double medianotas = somatorionotas / resultadonotas;

            Console.WriteLine("A média das notas é: " + medianotas);
        }
    }
}
