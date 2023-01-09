using System;

namespace VendedorSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o nome do vendedor: ");
            string nome = Console.ReadLine();


            Console.Write("Insira o salário fixo do vendedor: ");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());


            Console.Write("Insira o total de vendas efetuadas pelo vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());


            double comissao = totalVendas * 0.15;


            double salarioFinal = salarioFixo + comissao;


            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário fixo: " + salarioFixo.ToString("C"));
            Console.WriteLine("Salário final: " + salarioFinal.ToString("C"));
        }
    }
}
