// Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.

List<decimal> lista_reais = new List<decimal>();

lista_reais.Add(1.1M);
lista_reais.Add(1.2M);
lista_reais.Add(1.3M);
lista_reais.Add(1.4M);
lista_reais.Add(1.5M);
lista_reais.Add(1.6M);
lista_reais.Add(1.7M);
lista_reais.Add(1.8M);
lista_reais.Add(1.9M);
lista_reais.Add(1.10M);

lista_reais.Reverse();

foreach (var numero in lista_reais)
{
    System.Console.WriteLine(numero);
}
