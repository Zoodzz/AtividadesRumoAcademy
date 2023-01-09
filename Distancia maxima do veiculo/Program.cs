using System;

namespace DistanciaMaxima
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a capacidade do tanque em litros:");
            double capacidadeTanque = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustível em litros por 100 quilômetros:");
            double consumoCombustivel = double.Parse(Console.ReadLine());


            double distanciaMaxima = capacidadeTanque / (consumoCombustivel / 100);


            Console.WriteLine("Distância máxima: " + distanciaMaxima + " quilômetros");
        }
    }
}
