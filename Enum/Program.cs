using _18Enumeration;

Console.WriteLine("=== Enum ===\n");

// Console.WriteLine(DiasDaSemana.Domingo);
// Console.WriteLine(DiasDaSemana.Terça);

// int dia1 = (int)DiasDaSemana.Domingo;
// int dia2 = (int)DiasDaSemana.Terça;

// Console.WriteLine($"O {DiasDaSemana.Domingo} vale {dia1}");
// Console.WriteLine($"O {DiasDaSemana.Terça} vale {dia2}")

Console.WriteLine($"{DiasDaSemana.Domingo} -  {(int)DiasDaSemana.Domingo}");
Console.WriteLine($"{Categoria.Moda} - {(int)Categoria.Moda}");
Console.WriteLine($"{Categoria.Automotivo} - {(int)Categoria.Automotivo}");
Console.WriteLine($"{Categoria.Artes} - {(int)Categoria.Artes}");
Console.WriteLine($"{Categoria.Livros} - {(int)Categoria.Bebidas}");
Console.WriteLine($"{Categoria.Brinquedos} - {(int)Categoria.Brinquedos}");

Console.WriteLine("\nSelecione a categoria");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categoria)valor;
Console.WriteLine($"Voce selecionou {nomeMembroEnum.ToString()}");

Console.ReadKey();

