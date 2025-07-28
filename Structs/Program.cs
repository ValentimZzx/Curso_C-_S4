Console.WriteLine("=== Struct ===\n");



Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = Idade;
    }

    public void ExibirInfo()
    {
        Console.WriteLine();
    }
}