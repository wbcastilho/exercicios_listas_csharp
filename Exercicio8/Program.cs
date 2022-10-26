// Faça um Programa que peça a idade e a altura de 5 pessoas, 
// armazene cada informação no seu respectivo vetor. 
// Imprima a idade e a altura na ordem inversa a ordem lida.

List<int> idades = new List<int>();
List<int> alturas = new List<int>();

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine($"\nInforme a idade da pessoa {i+1}:");
    idades.Add(Convert.ToInt32(Console.ReadLine()));

    System.Console.WriteLine($"\nInforme a altura da pessoa {i+1}:");
    alturas.Add(Convert.ToInt32(Console.ReadLine()));
}

idades.Reverse();
alturas.Reverse();

System.Console.WriteLine("\nIdades");
foreach(var n in idades) System.Console.WriteLine(n);

System.Console.WriteLine("\nAlturas");
foreach(var n in alturas) System.Console.WriteLine(n);
