namespace AtividadePrimeiraAula

{
    class Atividade1
    {
        static void Main(string[] args)
        {
            double distanciaPercorridaKm = 0, consumoveiculoporLitro = 0, precocombustivel = 0;

            Console.WriteLine("Calculadora do preço de consumo de combustível\n\n ");

            Console.WriteLine("Digite a distância que irá percorrer em km: ");

            distanciaPercorridaKm = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o consumo do veículo por litro: ");

            consumoveiculoporLitro = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o preco do combustivel: ");

            precocombustivel = double.Parse(Console.ReadLine());


            double precototal = ((distanciaPercorridaKm / consumoveiculoporLitro) * precocombustivel);

            double consumoVeiculo = distanciaPercorridaKm / consumoveiculoporLitro;

            Console.WriteLine("O Preço total é: " + precototal + " R$ ");

            Console.WriteLine("Consumo do veiculo em Litros: " + consumoVeiculo + "L");
        }
    }
}