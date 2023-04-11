//numeros inteiros

int[]numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira seu {i + 1}º numero inteiro:");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

foreach (int numero in numeros)
{
    Console.WriteLine($"O dobro do numero escolhido é: {numero * 2}");
    
}
