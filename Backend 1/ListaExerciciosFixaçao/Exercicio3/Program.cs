// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <= 10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else
using System.Globalization;

float pagar;
string nome;
int quantidade;
float preco;
float total;

Console.WriteLine($"Informe o nome do produto: ");
nome = Console.ReadLine()!;

Console.WriteLine($"Informe a quantidade do produto: ");
quantidade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o preço do produto: ");
preco = float.Parse(Console.ReadLine()!);

total = quantidade * preco;

if (quantidade <= 5)
{
    pagar = total * 0.98f;

}
else if (quantidade > 5 && quantidade <= 10)
{
    pagar = total * 0.97f;
}
else
{
    pagar = total * 0.95f;

}

Console.WriteLine(@$"
--------------------------

Produto: {nome}                     /
Preço 1un: {preco.ToString("C")}    /
Quantidade: {quantidade}            /

--------------------------
O valor total a pagar é: {pagar.ToString("C", new CultureInfo("pt-BR"))}");
