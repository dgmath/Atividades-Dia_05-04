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

//Algoritmo

//saber o sexo do entrevistado
//se essa pessoa gostou do produto

//saber o numero de pessoas que responderam sim
//saber o numero de pessoas que responderam nao

//saber o numero de mulheres que responderam
//saber o numero de pessoas que responderam sim

//saber o numero de homens que responderam
//saber o nuemero de homens que responderam nao

//saber a porcentagem de homens que responderam o nao -------exibido

//declarar as variáveis

char sexo;
char resposta;

int totalSim = 0;
int totalNao = 0;

int totalMulher = 0;
int totalMsim = 0;

int totalHomem = 0;
int totalHomemNao = 0;

double porcentagemHomemN = 0;


// var i = 0; ------ inicializador
// i < length; ------ condicional
// i++ --------------- iterador

for (int i = 1; i <= 10; i++)
{
    //entrada de dados

    Console.WriteLine($"Informe o sexo da pessoa(f para feminino e m para masculino");
    sexo = char.Parse(Console.ReadLine()!);
    
    //processamento

    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }

    Console.WriteLine(@$"
    E se a pessoa gostou do produto 
    (s para sim e n para não)");
    resposta = char.Parse(Console.ReadLine()!);
    
    if(resposta == 's')
    {
        totalSim++;

        if(sexo == 'f')
        {
            totalMsim++;
        }
    }
    else
    {
        totalNao++;

        if(sexo == 'm')
        {
            totalHomemNao++;
        }
    }
}

porcentagemHomemN = Math.Round(((double)totalHomemNao/(double)totalHomemNao) *100,2);


Console.WriteLine($"O numero de pessoas que responderam sim foi {totalSim}%");
Console.WriteLine($"O numero de pessas que responderam não foi {totalNao}");
Console.WriteLine($"O numero de mulheres que responderam sim foi {totalMsim}");
Console.WriteLine($"A porcentagem de homens que responderam não foi de {porcentagemHomemN}");






// for(int contador = 0; contador <=10; contador++)
// {
//     Console.WriteLine($"Insira o sexo (f para feminino e m para masculino");
//     char sexo = char.Parse(Console.ReadLine()!);

//     Console.WriteLine($"E a resposta (s para sim e n para não) de seus funcionarios:");
//     char resposta = char.Parse(Console.ReadLine()!);

//     switch(resposta)
//     {
//         case 's':
//     	totalSim ++;

//         if(sexo == 'f')
//         {
//             totalMsim ++;
//         }
//         break;

//         case 'n':
//         totalNao ++;

//         if(sexo == 'm')
//         {
//             totalHomemNao ++;
//         }

//         break;
    
//     }

// }

// Console.WriteLine($"{totalSim}, {totalNao}, {totalMsim}, {totalHomemNao}");
