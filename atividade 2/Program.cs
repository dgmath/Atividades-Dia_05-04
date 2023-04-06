// programa senha

bool senhaCerta = true;
do
{
    Console.WriteLine($"Insira seu nome:");
    string nome = Console.ReadLine()!;
    
    Console.WriteLine($"Insira sua senha:");
    string senha = Console.ReadLine()!;
    
    if (senha == nome)
    {
        Console.WriteLine($"Por favor insira uma senha sem ser igual o numero do usuario.");
        senhaCerta = false;
    }
    else
    {
        Console.WriteLine($"parabens sua senha foi registrada.");
        senhaCerta = true;
    }
}while(senhaCerta == false);