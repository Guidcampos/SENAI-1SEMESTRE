Console.WriteLine($"Informe seu salarario: ");
float salario = float.Parse(Console.ReadLine());



Console.WriteLine($"Informe seu gasto mensal:");
float gasto = float.Parse(Console.ReadLine());


if (salario > gasto)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine($"Salario: {salario} reais");
    Console.WriteLine($"Gasto: {gasto} reais");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine($"Gastos dentro do orçamento!");
    Console.ResetColor();
}

else {
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine($"Salario: {salario} reais");
    Console.WriteLine($"Gasto: {gasto} reais");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine($"Orçamento estourado");
    Console.ResetColor();
}