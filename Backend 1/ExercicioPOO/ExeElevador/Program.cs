// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);

// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);

// Encapsular todos os atributos da classe (criar os métodos set e get).

using ExeElevador;

Elevador a1 = new Elevador();

// a1.totalAndares = 9;
// a1.capacidade = 5;

Console.WriteLine($"Qual a capacidade do seu elevador:");
a1.capacTotal = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Quantos andares tem seu elevador:");
a1.andarTotal = int.Parse(Console.ReadLine()!);



a1.Inicializa(a1.capacTotal, a1.andarTotal);

string opcao;
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
                ELEVADOR
[1] - Subir.
[2] - Descer.
[3] - Entrar no elevador.
[4] - Sair do elevador.
[0] - Sair do menu.
=============================================
");
    Console.ResetColor();

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            a1.Subir();
            break;
        case "2":
            Console.Clear();
            a1.Descer();
            break;
        case "3":
            // Console.Clear();
            a1.Entrar();
            break;
        case "4":
            Console.Clear();
            a1.Sair();
            break;
        case "0":
            Console.WriteLine($"Saindo do menu...");
            break;
        default:
            Console.WriteLine($"Opção invalida.");
            break;
    }
} while (opcao != "0");


