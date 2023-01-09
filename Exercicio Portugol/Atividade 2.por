programa
{
	
	funcao inicio()
	{    
          escreva("Calculadora da distância máxima do veículo\n\n")
		
		real quantiaAbastecidoLitros
		escreva("Qual foi o valor em litros que você colocou em seu veículo?:")
		leia(quantiaAbastecidoLitros)
         
          real consumoDoveiculo
		escreva("Qual é o consumo do seu veiculo?: ")
		leia(consumoDoveiculo)
          
          real distanciaMaximaVeiculo = quantiaAbastecidoLitros * consumoDoveiculo
		escreva("Seu carro pode andar no máximo:" + distanciaMaximaVeiculo + " Km ")
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 112; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */