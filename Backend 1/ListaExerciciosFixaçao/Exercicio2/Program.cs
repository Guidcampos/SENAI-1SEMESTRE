// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

using System.Globalization;

bool resposta = true;
char TipoC;
float litros;
float total;


static float gasolina(float litros)
{

    float vlg = 5.30F;
    float vldescg;

    if (litros <= 20)
    {

        vldescg = (vlg - (vlg * 0.04F)) * litros;

    }
    else
    {

        vldescg = (vlg - (0.06F * vlg)) * litros;

    }

    return vldescg;

}

static float alcool(float litros)
{

    float vlA = 4.90F;
    float vldescA;

    if (litros <= 20)
    {

        vldescA = (vlA - (vlA * 0.03F)) * litros;

    }
    else
    {

        vldescA = (vlA - (0.05F * vlA)) * litros;

    }

    return vldescA;

}

do
{

    Console.WriteLine($"Escolha seu combustivel: A-álcool, G-gasolina ");
    TipoC = char.Parse(Console.ReadLine()!.ToUpper());


    switch (TipoC)
    {
        case 'A':
            Console.WriteLine($"Quantos litros deseja: ");
            litros = float.Parse(Console.ReadLine()!);

            total = alcool(litros);

            Console.WriteLine($@"voce pediu {litros} litros de alcool, sua conta deu {total.ToString("C", new CultureInfo("pt-BR"))} reais");
            break;

        case 'G':
            Console.WriteLine($"Quantos litros deseja: ");
            litros = float.Parse(Console.ReadLine()!);

            total = gasolina(litros);

            Console.WriteLine($@"voce pediu {litros} litros de gasolina, sua conta deu {total.ToString("C", new CultureInfo("pt-BR"))} reais");
            break;

        default:
            resposta = false;
            Console.WriteLine($"Escolha invalida");
            break;

    }
} while (resposta == false);














