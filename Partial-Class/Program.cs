using _22MinhaPartialClass;

Console.WriteLine("=== Partial Class ===");

MinhaPartialClass minhaPartial = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em : 07/08/2003");
var idade = minhaPartial.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para nascidos em : 02/06/2005");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);

var diferenca = minhaPartial.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");

Console.ReadKey();