// 1- Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

int anoatual;
int nascimento;
int idade;

Console.WriteLine($"Para saber se está apto a votar, por favor informe o ano atual:");
anoatual = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o ano de nascimento:");
nascimento = int.Parse(Console.ReadLine()!);


idade = anoatual - nascimento;

if (idade == 16 || idade == 17 || idade > 64)

{
    Console.WriteLine($"Voce está apto a votar");

}


else if (idade >= 18)
{
    Console.WriteLine($"Voce é obrigado a votar");

}

else
{
    Console.WriteLine($"Você não possui idade para votar");

}



