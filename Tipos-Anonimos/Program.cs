Console.WriteLine("=== Tipos Anonimos ===");

var aluno = new
{
    Id = 1,
    Nome = "Nícolas",
    Idade = 21,
    Email = "nvalentim824@gmail.com",
    Endreço = new { Id = 1, Cidade = "Goiania", Pais = "Brasil" }
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endreço.Cidade);

Console.ReadKey();