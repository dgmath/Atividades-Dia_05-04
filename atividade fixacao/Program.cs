//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. 
//Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int[]numeros = new int [6];
int numeropar = 0;
int numeroimpar = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Insira seu {i + 1}º numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++)
{
    if (numeros[i] % 2 == 0)
    {
        numeropar++;
    }
    else
    {
        numeroimpar++;
    }
}

Console.WriteLine($"Há {numeropar} pares e {numeroimpar} impares");

