// Faça um Programa que leia um vetor A com 10 números inteiros, 
// calcule e mostre a soma dos quadrados dos elementos do vetor.

List<int> numeros = new List<int> { 2, 4, 8, 7, 3, 4, 12, 20, 32, 40 };

int soma = numeros.Sum();
int quadrado = soma ^ 2;

System.Console.WriteLine($"A soma dos quadrados é {quadrado}");
