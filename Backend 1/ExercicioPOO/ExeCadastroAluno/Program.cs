// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using System.Globalization;
using ExeCadastroAluno;

Aluno a1 = new Aluno();



Console.WriteLine($"Informe seu nome:");
a1.Nome = Console.ReadLine()!;

Console.WriteLine($"Informe seu Curso:");
a1.Curso = Console.ReadLine()!;

Console.WriteLine($"Informe sua idade:");
a1.Idade = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Media final: ");
a1.MediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Valor da mensalidade: ");
a1.ValorMensa = float.Parse(Console.ReadLine()!);


bool respostaCerta;
do
{

    Console.WriteLine($"Você é bolsista: S/N");
    string resposta = Console.ReadLine()!.ToUpper();


    switch (resposta)
    {

        case "S":
            a1.Bolsista = true;
            respostaCerta = true;
            break;

        case "N":
            a1.Bolsista = false;
            respostaCerta = true;
            break;


        default:
            Console.WriteLine($"Resposta invalida");
            respostaCerta = false;
            break;

    }

} while (respostaCerta == false);

int menu;
do
{
    Console.WriteLine(@$"


=========================================
           Seja bem-vindo 
Selecione uma das seguingtes operações:

       [1] - VER MÉDIA FINAL 
       [2] - VER MENSALIDADE 
       [0] - Sair.
==========================================

");
    menu = int.Parse(Console.ReadLine()!);

    switch (menu)
    {
        case 0:
            {
                break;
            }

        case 1:
            {
                Console.WriteLine($@"   
        Aluno: {a1.Nome}
        Curso: {a1.Curso}
        ");
                a1.VerMediaFinal();
                break;

            }

        case 2:
            {
                Console.WriteLine($@"
        Aluno: {a1.Nome}
        Curso: {a1.Curso}
        Mensalidade: {a1.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}");

                break;
            }

        default:
            Console.WriteLine($"Entrada inválida. Tente novamente");
            break;
    }
} while (menu != 0);





















