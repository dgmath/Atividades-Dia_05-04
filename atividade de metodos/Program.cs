// criar metodo para multiplicar 2 numeros
// criar metodo para dividir 2 numeros
// criar metodo para subtrair 2 numeros

static float Multiplicar(float n1, float n2);
{
    return (n1*n2);
}

Console.WriteLine($"Insira o primeiro número: ");
float n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Insira o segundo número: ");
float n2 = float.Parse(Console.ReadLine()!);

float resultado = Multiplicar(n1,n2);

Console.WriteLine($"O resultado da soma é: {resultado}");


//Console.WriteLine($"{resultado}");
