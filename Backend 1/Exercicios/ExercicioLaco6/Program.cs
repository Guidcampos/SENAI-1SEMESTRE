// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// Exemplo: tabuada do 1, tabuada do 2, etc...
// Dica: utilize um laço dentro do outro.

for (int num = 1; num <= 10; num++)
{
    Console.WriteLine($"\nTABUADA DO NÚMERO: {num}");

    for (int mult = 1; mult <= 10; mult++)
    {
        int resultado = num * mult;
        Console.WriteLine($"{num} x {mult} = {resultado}");
    }

}