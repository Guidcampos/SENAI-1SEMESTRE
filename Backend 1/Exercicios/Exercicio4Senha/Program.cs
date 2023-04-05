const int senhaacesso = 1234;

Console.WriteLine($"Informar senha de acesso: ");
int senha = int.Parse(Console.ReadLine());

if (senhaacesso == senha)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine($"ACESSO LIBERADO");
    Console.ResetColor();
    
}

else {
    
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine($"ACESSO NEGADO");
    Console.ResetColor();
    
}
