// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.


bool sexook = false;
bool respostaok = false;
int homem = 0;
int mulher = 0;
int homems = 0;
int homemn = 0;
int mulhers = 0;
int mulhern = 0;

for (int pg = 1; pg <= 10; pg++)
{

    do
    {

        Console.WriteLine($"Qual seu sexo: (h) Homem ou (m) Mulher");
        char sexo = char.Parse(Console.ReadLine()!);

        do
        {
            switch (sexo)
            {

                case 'h':
                    Console.WriteLine($"Voce gostou do produto: (s) Sim ou (n) Não");
                    char resposta = char.Parse(Console.ReadLine()!);

                    switch (resposta)
                    {
                        case 's':
                            homem++;
                            homems++;
                            respostaok = true;
                            sexook = true;
                            break;

                        case 'n':
                            homem++;
                            homemn++;
                            respostaok = true;
                            sexook = true;
                            break;

                        default:
                            Console.WriteLine($"Resposta invalida");
                            respostaok = false;
                            break;
                    }
                    break;



                case 'm':
                    Console.WriteLine($"Voce gostou do produto: (s) Sim ou (n) Não");
                    resposta = char.Parse(Console.ReadLine()!);

                    switch (resposta)
                    {
                        case 's':
                            mulher++;
                            mulhers++;
                            respostaok = true;
                            sexook = true;
                            break;

                        case 'n':
                            mulher++;
                            mulhern++;
                            respostaok = true;
                            sexook = true;
                            break;

                        default:
                            Console.WriteLine($"Resposta invalida");
                            respostaok = false;
                            break;
                    }
                    break;

                default:
                    Console.WriteLine($"Sexo invalido");
                    sexook = false;
                    break;

            }

        } while (respostaok == false);

    } while (sexook == false);


Console.WriteLine($@"
Número de entrevistados {homem + mulher}
Número de pessoas que responderam SIM: {homems + mulhers}
Número de pessoas que responderam NAO: {homemn + mulhern}
Número de mulheres que responderam SIM: {mulhers}
Homens que responderam NAO entre os homens: {(100 * (double)homemn) / (double)homem}%");
}
