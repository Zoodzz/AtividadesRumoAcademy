programa
{
	inclua biblioteca Objetos
	
	     real distanciaPercorridaKm = 0, consumoveiculoporLitro = 0, precocombustivel = 0
	
	funcao inicio()
	
	{    escreva("Calculadora do preço de consumo de combustível\n\n ")
		escreva("\nDigite a distância que irá percorrer em km: ")
		leia(distanciaPercorridaKm)
		escreva("\nDigite o consumo do veículo por litro: ")
		leia(consumoveiculoporLitro)
	     escreva("\nDigite o preco do combustivel: ")
		leia(precocombustivel)
		
		
	      // dividir a distanciaPercorridaKm pelo consumoveiculoporLitro e multiplicar o resultado pelo precocombustivel para saber
		// o resultado do preço total de consumo na variavel precototal
		
		real precototal = ((distanciaPercorridaKm / consumoveiculoporLitro) * precocombustivel)
		real consumoVeiculo = distanciaPercorridaKm / consumoveiculoporLitro
		escreva("\nO Preço total é: " + precototal + " R$ ")
		escreva("\nConsumo do veiculo em Litros: " + consumoVeiculo + "L" )  
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 217; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */