//Mercado e entrevistados

// // Console.WriteLine($"Insira o sexo (1 para feminino e 2 para masculino");
// // int sexo = int.Parse(Console.ReadLine()!);

// // Console.WriteLine($"E a resposta (1 para sim e 2 para não) de seus funcionarios:");
// // int resposta = int.Parse(Console.ReadLine()!);

// for(char sexo = 1 ; sexo <=10; sexo++)
// {
//     Console.WriteLine($"insira");
//     char sexo = char.Parse(Console.ReadLine()!);
    
// }

// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int psim = 0;
int pnao = 0;
int femS = 0;
int pmascN = 0;

for(int contador = 0; contador <=10; contador++)
{
    Console.WriteLine($"Insira o sexo (f para feminino e m para masculino");
    char sexo = char.Parse(Console.ReadLine()!);

    Console.WriteLine($"E a resposta (s para sim e n para não) de seus funcionarios:");
    char resposta = char.Parse(Console.ReadLine()!);

    switch(resposta)
    {
        case 's':
    	psim ++;

        if(sexo == 'f')
        {
            femS ++;
        }
        break;

        case 'n':
        pnao ++;

        if(sexo == 'm')
        {
            pmascN ++;
        }

        break;
    
    }

}

Console.WriteLine($"{psim}, {pnao}, {femS}, {pmascN}");
