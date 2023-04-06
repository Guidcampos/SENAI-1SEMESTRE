// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.


Console.WriteLine($"Insira um numero:");
int num = int.Parse(Console.ReadLine()!);

while(num < 0 || num == 0)
{
    Console.WriteLine($"Valor inválido. Digite um número novamente: ");
    num = int.Parse(Console.ReadLine()!);
}


for (int t = 0; t <=10 ; t++)
{
    Console.WriteLine($"{num} x {t} = {num * t}");
    
}