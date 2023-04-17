//5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
//Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

int numero = 1;

for (int cont = 1; cont <= 10; cont++)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine($@"
    A tabuada do {numero}! ");

    Console.ResetColor();

    for (int cont2 = 1; cont2 <= 10; cont2++)
    {
        Console.WriteLine($@"
        {numero} x {cont2} = {numero * cont2}");
    }
    numero++;
}