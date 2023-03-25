Console.Clear();

Console.Write($"Digite seu nome....  ");

string nome;
nome = Console.ReadLine()!;


Console.Write($"Digite seu sobrenome....  ");

string sobrenome;
sobrenome = Console.ReadLine()!;

string nomeCompleto = (nome) + (sobrenome);

Console.WriteLine();
Console.Write("Nome Completo: ");
Console.WriteLine($"{nome} { sobrenome}");

Console.Write("Nome de catálogo: ");
Console.WriteLine($"{sobrenome}, {nome}");