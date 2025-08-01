Console.WriteLine("=== Bloco Try-Catch ===");

Console.WriteLine("Informe um numero: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe mais um numero: ");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"O resultado de {x} dividido por {y} é: {z}");
}

catch (Exception ex)
{
    Console.WriteLine("Não existe divisão por zero, tente outro número...");
    Console.WriteLine($"\nErro: <<<{ex.Message}>>>");
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");
}   


Console.ReadKey();