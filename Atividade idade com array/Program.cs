// Idade

int[]arrayIdade = new int[5];
string[]arrayNome = new string[5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira o {i + 1}º nome: ");
    arrayNome[i] = Console.ReadLine()!;
    
    Console.WriteLine($"Insira a {i + 1}º idade: ");
    arrayIdade[i] = int.Parse(Console.ReadLine()!);
    
}

for (var i = 0; i < 5; i++)
{   Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"{i + 1}) Nome: {arrayNome[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"Idade: {arrayIdade[i]} anos
    
    ");   
}