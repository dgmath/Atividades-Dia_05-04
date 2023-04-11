//Atividade dos carros

string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome do carro:");
    carros[i] = Console.ReadLine()!;
    
}

for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
}