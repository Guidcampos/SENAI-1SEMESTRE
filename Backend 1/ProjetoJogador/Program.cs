using ProjetoJogador;

JogadorATQ jA = new JogadorATQ();
JogadorDEF jD = new JogadorDEF();
JogadorMEI jM = new JogadorMEI();




string opcao;
do
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($@"
============================================
Escolha sua posição

[1] - Atacante
[2] - Meio Campo
[3] - Defesa
[0] - Encerrar sistema.
=============================================
");
    Console.ResetColor();
    opcao = Console.ReadLine()!;
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($@"Voce optou pelo ataque, prossiga com seus dados:
            ");
            jA.Cadastro();
            Console.Clear();
            Console.WriteLine($@"
                ATACANTE CADASTRADO");
            jA.ImprimiJogador();
            jA.Aposentar();
            break;

        case "2":
            Console.WriteLine($@"Voce optou pelo Meio Campo, prossiga com seus dados:
            ");
            jM.Cadastro();
            Console.Clear();
            Console.WriteLine($@"
                MEIO CAMPISTA CADASTRADO");
            jM.ImprimiJogador();
            jM.Aposentar();
            break;

        case "3":
            Console.WriteLine($@"Voce optou pela Defesa, prossiga com seus dados:
            ");
            jD.Cadastro();
            Console.Clear();
            Console.WriteLine($@"
                Zaqueiro CADASTRADO");
            jD.ImprimiJogador();
            jD.Aposentar();
            break;

        case "0":
            Console.WriteLine($"Encerrando...");
            break;

        default:
            break;
    }
} while (opcao != "0");











