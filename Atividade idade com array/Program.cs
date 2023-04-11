// Idade

int[]arrayIdade = new int[5];
string[]arrayNome = new string[5];

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Insira seu nome: ");
    arrayNome[i] = Console.ReadLine()!;
    
    Console.WriteLine($"Insira sua idade: ");
    arrayIdade[i] = int.Parse(Console.ReadLine()!);
    
}

for (var i = 0; i < 2; i++)
{   Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"{i + 1}) nome: {arrayNome[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"Idade: {arrayIdade[i]} anos
    
    ");
    
}