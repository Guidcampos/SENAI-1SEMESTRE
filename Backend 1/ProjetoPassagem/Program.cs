
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

string senhainformada;
const string senhasistema = "321";
bool menuopcao = true;


static bool login(string senhainformada)
{
    bool senhacerta = senhainformada == senhasistema ? true : false;
    return senhacerta;
}

do
{
    Console.WriteLine($"Por favor, informe sua senha: ");
    senhainformada = Console.ReadLine()!;

} while (login(senhainformada) == false);

Console.WriteLine($"ACESSO LIBERADO");

Console.WriteLine($@"
------------------------------
           MENU
    1- Cadastrar passagem
    2- Listar Passagens
        0- Sair
------------------------------");

do
{

    Console.WriteLine($"Escolha uma opção:");
    char opcao = char.Parse(Console.ReadLine()!);

    switch (opcao)
    {

        case '1':
            menuopcao = true;
            break;


        case '2':
            menuopcao = true;
            break;


        case '0':
            menuopcao = true;
            break;

        default:
            menuopcao = false;
            break;

    }




} while (menuopcao == false);


























