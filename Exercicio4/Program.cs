// Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes foram lidas. Imprima as consoantes.

List<char> listaCaracteres = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

var caracteres = listaCaracteres.Where(x => !x.Equals('a') 
                                       && !x.Equals('e') 
                                       && !x.Equals('i') 
                                       && !x.Equals('o') 
                                       && !x.Equals('u')).ToList();

System.Console.WriteLine(caracteres.Count());
