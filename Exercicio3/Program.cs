// Faça um Programa que leia 4 notas, mostre as notas e a média na tela.

List<decimal> valores = new List<decimal> { 4.2M, 5.8M, 6M, 7.3M};

var soma = valores.Sum();
var media = soma / 4;

System.Console.WriteLine(media);


