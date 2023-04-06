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



// Console.WriteLine($"Qual seu sexo: (h) Homem ou (m) Mulher");
// char sexo = char.Parse(Console.ReadLine()!);

// Console.WriteLine($"Voce gostou do produto: (s) Sim ou (n) Não");
// char resposta = char.Parse(Console.ReadLine()!);

for (int pg = 0; pg <= 10; pg++)
{

    Console.WriteLine($"Qual seu sexo: (h) Homem ou (m) Mulher");
    char sexo = char.Parse(Console.ReadLine()!);

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
                    break;

                case 'n':
                    homem++;
                    homemn++;
                    break;

                default:
                    Console.WriteLine($"Resposta invalida");
                    Console.WriteLine($"Voce gostou do produto: (s) Sim ou (n) Não");
                    resposta = char.Parse(Console.ReadLine()!);
                    break;
            }
            break;


            
    }

}
