using System;

string[] nomes = new string[10];
int[] Idades = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Insira o nome da pessoa:");
    nomes[i] = Console.ReadLine();
    Console.WriteLine("Insira a idade da pessoa:");
    Idades[i] = int.Parse(Console.ReadLine());
}
int idadeDoMaisvelho = Idades[0];
string nomedomaisVelho = nomes[0];

for (int i = 1; i < 10; i++)
{
    if (Idades[i] > idadeDoMaisvelho)
    {
        idadeDoMaisvelho = Idades[i];
        nomedomaisVelho = nomes[i];

        Console.WriteLine("A pessoa mais velha é " + nomedomaisVelho + " com " + idadeDoMaisvelho + " anos.");

    }
}

