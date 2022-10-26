// Faça um Programa que peça as quatro notas de 10 alunos, 
// calcule e armazene num vetor a média de cada aluno, 
// imprima o número de alunos com média maior ou igual a 7.0.

List<double> mediaAlunos = new List<double>();

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"Informe as quatro notas do aluno {i + 1}:");
    List<double> notas = new List<double>();

    for (int j = 0; j < 4; j++)
    {
        notas.Add(Convert.ToDouble(Console.ReadLine()));
    }

    double soma = notas.Sum();
    double media = soma / 4;
    mediaAlunos.Add(media);
}

var alunosNaMedia = mediaAlunos.Where(x => x >= 7);

System.Console.WriteLine($"Quantidade com alunos que pegaram média: {alunosNaMedia.Count()}");

