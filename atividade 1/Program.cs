//pograma nota

bool notaCerta = true;

do
{
    Console.WriteLine($"Insira uma nota entre 0 e 10:");
    float nota = float.Parse(Console.ReadLine()!);

    if(nota >= 0 && nota <= 10)
    {
    Console.WriteLine($"Parabéns sua nota: {nota} foi registrada com sucesso");
    notaCerta = true;
    }
    else
    {
        Console.WriteLine($"Por favor insira uma nota valida!");
        notaCerta = false;
    }
    
}while(notaCerta == false);
