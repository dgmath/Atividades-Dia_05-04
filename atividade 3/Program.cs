// Numero e tabuada
  int formula, contador; 
   Console.WriteLine("Digite um numero e receba a tabuada : ");
    int tabuada = int.Parse(Console.ReadLine()!);
    
    for (contador = 1; contador <= 10; contador++)
    {
        formula = tabuada * contador;
        Console.WriteLine(tabuada + " X " + contador + " = " + formula);
    }
