int idade = 0;
bool estadocv = true;
string nomeestado = "";

Console.WriteLine($"Informe seu nome:");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Seu nome nâo pode estar vazio");

    Console.WriteLine($"Informe seu nome:");
    nome = Console.ReadLine()!;
}
Console.WriteLine($"Informe sua idade: ");
idade = int.Parse(Console.ReadLine()!);

while (idade <= 0 || idade >= 100)
{
    Console.WriteLine($"Sua idade é invalida!");
    Console.WriteLine($"Informe sua idade: ");
    idade = int.Parse(Console.ReadLine()!);

}

Console.WriteLine($"Informe seu Salario:");
float salario = float.Parse(Console.ReadLine()!);

while (salario <= 0)
{
    Console.WriteLine($"Salario invalido");
    Console.WriteLine($"Informe seu Salario:");
    salario = float.Parse(Console.ReadLine()!);
}

do
{

    Console.WriteLine($"Qual seu estado civil: (s) solteiro, (c) casado, (v) viuvo e (d) divorciado");
    char estadocivil = char.Parse(Console.ReadLine()!);

    switch (estadocivil)
    {
        case 's':
            nomeestado = "Solteiro";
            estadocv = true;
            break;

        case 'c':
            nomeestado = "Casado";
            estadocv = true;
            break;


        case 'v':
            nomeestado = "Viuvo";
            estadocv = true;
            break;


        case 'd':
            nomeestado = "Divorciado";
            estadocv = true;
            break;

        default:

            estadocv = false;
            Console.WriteLine($"Escolha invalida");

            break;

    }
    } while (estadocv == false);
    Console.WriteLine(@$"
Confirme seus Dados:

Seu nome: {nome}
Sua idade: {idade}
Seu salario: {salario}
Seu estado civil: {nomeestado}");



