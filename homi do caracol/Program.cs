// Homi do caracol
    int inicio0 = 0;
    int inicio1 = 1;
for (int caracol = 0; caracol <= 500;)
{
    caracol = inicio0 + inicio1;
    Console.WriteLine(caracol);
    inicio0 = inicio1;
    inicio1 = caracol;  
}
