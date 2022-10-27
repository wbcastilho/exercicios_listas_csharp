// Faça um Programa que leia dois vetores com 10 elementos cada. Gere um terceiro vetor de 20 elementos, 
// cujos valores deverão ser compostos pelos elementos intercalados dos dois outros vetores.

List<int> vetor1 = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
List<int> vetor2 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
List<int> resultado = new List<int>();

for (int i = 0; i < 10; i++)
{
    resultado.Add(vetor1[i]);
    resultado.Add(vetor2[i]);
}

System.Console.WriteLine("Exibir vetor resultante: ");
foreach (var r in resultado)
{
    System.Console.WriteLine(r);
}

