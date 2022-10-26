// Faça um Programa que leia um vetor de 5 números inteiros, mostre a soma, a multiplicação e os números

List<int> numeros = new List<int> { 1, 5, 8, 10, 9 };

int soma=0, multiplicacao=1;

foreach (var n in numeros)
{
    soma += n;
    multiplicacao *= n;

    System.Console.WriteLine($"Número: {n}");
}

System.Console.WriteLine($"\nSoma: {soma}");
System.Console.WriteLine($"\nMUltiplicação: {multiplicacao}");


