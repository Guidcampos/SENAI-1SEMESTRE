
// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

using System.Globalization;

string[] nome = new string[10];
float[] preco = new float[10];
string[] promocao = new string[10];


static void cadastrarProduto(string[] nome, float[] preco, string[] promocao, int i)
{

    Console.WriteLine($@"
    ---------------------------------

    Insira o nome do produto:");
    nome[i] = Console.ReadLine()!;

    Console.WriteLine($@"
    
    Insira o preço do produto:");
    preco[i] = float.Parse(Console.ReadLine()!);

    Console.WriteLine($@"
    
    Este produto está em promoção? S/N");
    string resposta = Console.ReadLine()!.ToUpper();

    bool promo = false;
    do
    {
        switch (resposta)
        {

            case "S":
                promo = true;
                break;

            case "N":
                promo = false;
                break;

            default:
                break;

        }
    } while (resposta != "S" && resposta != "N");

    promocao[i] = promo == true ? "Produto em promoção" : "Produto não está em promoção";

}

string opcao;

do
{

    Console.WriteLine($@"
------------------------------
           MENU
    1- Cadastrar Produtos
    2- Listar Produtos
        0- Sair
------------------------------");

    Console.WriteLine($"Escolha uma opção:");
    opcao = Console.ReadLine()!;

    string novocad = "";
    
        switch (opcao)
        {

            case "1":

                do

                {

                    for (int i = 0; i < 5; i++)
                    {

                        cadastrarProduto(nome, preco, promocao, i);

                    }

                    Console.WriteLine($@"
                    -----------------------------------------------
                    Deseja realizar mais um cadastro? Sim/Nao");
                    novocad = Console.ReadLine()!.ToUpper();


                } while (novocad == "SIM");

                break;

            case "2":

                for (int i = 0; i < 5; i++)
                {

                    Console.WriteLine($@"
                
                --------------------------------------
                
                    Nome:    {nome[i]}
                    Preço:  {preco[i].ToString("C", new CultureInfo("pt-Br"))}
                    Promoção: {promocao[i]}
               
               ---------------------------------------- ");

                }

                break;

            case "0":
                Console.WriteLine($"Fim de programa");
                break;


            default:
                Console.WriteLine($"Opção invalida");
                break;
        }

    } while (opcao != "0");














                  

        

