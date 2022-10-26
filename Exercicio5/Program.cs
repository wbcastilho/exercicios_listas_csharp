// Faça um Programa que leia 20 números inteiros e armazene-os num vetor. Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. Imprima os três vetores.

List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 10, 22, 35, 36, 48, 45, 59, 60, 81, 85, 86, 90, 101, 102 };

var numerosPares = listaNumeros.Where(x => x % 2 == 0);
var numerosImpares = listaNumeros.Where(x => x % 2 != 0);

System.Console.WriteLine("Todos os números");
foreach (var numero in listaNumeros)
{
    System.Console.WriteLine(numero);
}

System.Console.WriteLine("\nNúmeros Pares");
foreach (var numero in numerosPares)
{
    System.Console.WriteLine(numero);
}

System.Console.WriteLine("\nNúmeros Impares");
foreach (var numero in numerosImpares)
{
    System.Console.WriteLine(numero);
}
