
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

bool nvcad = true;
bool Stop = false;
bool menu = false;



string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

static void cadastrarPassagens(string[] ns, string[] ori, string[] dest, string[] dt, int pos)
{

    Console.WriteLine($"Insira seu nome:");
    ns[pos] = Console.ReadLine()!;

    Console.WriteLine($"Insira a origem do seu voo:");
    ori[pos] = Console.ReadLine()!;

    Console.WriteLine($"Insira o destino do seu voo:");
    dest[pos] = Console.ReadLine()!;

    Console.WriteLine($"Insira a data do seu voo: (dd/mm/aa)");
    dt[pos] = Console.ReadLine()!;

}





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

char novocad = 'a';

do
{

    Console.WriteLine($@"
------------------------------
           MENU
    1- Cadastrar passagem
    2- Listar Passagens
        0- Sair
------------------------------");

    Console.WriteLine($"Escolha uma opção:");
    char opcao = char.Parse(Console.ReadLine()!);

    switch (opcao)
    {

        case '1':

            for (int i = 0; i < 2; i++)
            {
                do

                {


                    cadastrarPassagens(nome, origem, destino, data, i);



                    Console.WriteLine($"Deseja realizar mais um cadastro? S/N");
                    novocad = char.Parse(Console.ReadLine()!.ToUpper());


                    switch (novocad)
                    {

                        case 'S':
                            break;

                        case 'N':
                            menu = true;
                            i = 3;
                            break;

                        default:

                            break;

                    }
                } while (novocad == 'S');
            }













            menu = false;
            Stop = false;
            menuopcao = true;
            break;

        case '2':

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Nome: {nome[i]}");
                Console.WriteLine($"Origem: {origem[i]}");
                Console.WriteLine($"Destino: {destino[i]}");
                Console.WriteLine($"Data: {data[i]}");

            }

            Stop = false;
            menuopcao = true;
            menu = false;
            break;


        case '0':
            Stop = false;
            menuopcao = true;
            menu = false;
            break;

        default:
            menuopcao = false;
            menu = true;
            Stop = true;
            break;

    }

} while (novocad == 'N' && novocad != 'S');




















// string[] nome = new string[5];


// static string cadastro()
// {

// bool nvcad = true;
// bool Stop = false;  




//     for (int i = 0; i < 2; i++)
//     {
//         Console.WriteLine($"Insira seu nome:");
//         nome[i] = Console.ReadLine()!;

//         Console.WriteLine($"Insira a origem do seu voo:");
//         origem[i] = Console.ReadLine()!;

//         Console.WriteLine($"Insira o destino do seu voo:");
//         destino[i] = Console.ReadLine()!;

//         Console.WriteLine($"Insira a data do seu voo: (dd/mm/aa)");
//         data[i] = (Console.ReadLine()!);

//         if (i == 1){
//             break;
//         }

// do
// {
//     Console.WriteLine($"Deseja realizar mais um cadastro? S/N");
//     char novocad = char.Parse(Console.ReadLine()!.ToUpper());

//     switch (novocad)
//     {

//         case 'S':
//             nvcad = true;
//             Stop = false;
//             break;

//         case 'N':
//            Stop = true;
//             break;


//         default:
//             nvcad = false;
//             break;
//     }


// } while (nvcad == false);


//  if (Stop == true){
//     break;
//  }


//     }

//      string retorno = $"{nome.Length}";


//     return retorno;


// }

// cadastro();




























