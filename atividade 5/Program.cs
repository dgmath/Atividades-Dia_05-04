// idade sexo e peso
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int sexom = 0;
int sexof = 0;
int midadem = 0;
int midadef = 0;

for(int contador = 0; contador <=10; contador++)
{   
    Console.WriteLine($"Insira sua idade:");
    int anos = int.Parse(Console.ReadLine()!);
    
    Console.WriteLine($"Insira o sexo (f para feminino e m para masculino");
    char sexo = char.Parse(Console.ReadLine()!);

    Console.WriteLine($"insira seu peso:");
    float resposta = float.Parse(Console.ReadLine()!);

    switch(sexo)
    {
        case 'm':
    	sexom++;
        midadem += anos;
        break;

        case 'f':
        sexof++;
        midadef += anos;
        break;
    }
}
Console.WriteLine($"O total de homens é de: {sexom}");
Console.WriteLine($"O total de homens é de: {sexof}");
Console.WriteLine($"A média de idades masculinas é de: {midadem/sexom}");
Console.WriteLine($"A média de idades femininas é de: {midadef/sexof}");

