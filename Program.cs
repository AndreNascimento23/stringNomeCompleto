
Console.Clear();

Console.Write($"Digite seu nome....  ");

string nome, sobrenome;
nome = Console.ReadLine()!;

Console.Write($"Digite seu sobrenome....  ");
sobrenome = Console.ReadLine()!;

Console.WriteLine();
Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine();
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome.ToLower()}");
