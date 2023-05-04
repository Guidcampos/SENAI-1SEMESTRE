// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using ExeCelular;

Celular c1 = new Celular();

int menu;
do
{
    Console.WriteLine(@$"


=========================================
           Seja bem-vindo 
Selecione uma das seguingtes operações:

       [1] - Ligar Celular
       [2] - Desligar Celular
       [3] - Enviar SMS
       [4] - Fazer ligação
       [5] - Meu Celular
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
                if (c1.Ligado == false)
                {
                    c1.Ligar();
                }

                else
                {
                    Console.WriteLine($@"Celular já está ligado!");
                }
               
                break;




            }

        case 2:
            {

                break;
            }

        case 3:
            {
                break;
            }

        case 4:
            {
                break;
            }

        default:
            Console.WriteLine($"Entrada inválida. Tente novamente");
            break;
            
    }
    
} while (menu != 0);