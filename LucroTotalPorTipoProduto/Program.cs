using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucroPorProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();


            double lucroTotal = 0;


            while (true)
            {

                Console.WriteLine("Informe o nome do produto (ou 'sair' para parar):");
                string nome = Console.ReadLine();
                if (nome == "sair") break;

                Console.WriteLine("Informe a quantidade vendida:");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o preço de compra:");
                double precoCompra = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o preço de venda:");
                double precoVenda = double.Parse(Console.ReadLine());


                Produto produto = new Produto(nome, quantidade, precoCompra, precoVenda);


                produtos.Add(produto);


                lucroTotal += produto.CalculaLucro();
            }


            Console.WriteLine("Lucro total: " + lucroTotal.ToString("C"));
        }
    }


    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }

        public Produto(string nome, int quantidade, double precoCompra, double precoVenda)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;
        }


        public double CalculaLucro()
        {
            return Quantidade * (PrecoVenda - PrecoCompra);
        }
    }
}