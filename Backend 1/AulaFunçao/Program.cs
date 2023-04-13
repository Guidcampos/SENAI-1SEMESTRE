// criar metodo para multiplicar 2 n
// criar metodo para dividir 2 n
// criar metodo para subtrair 2 n




static float Multiplicacao(float n1, float n2)
{

    return n1 * n2;

}

static float Somar(float n1, float n2)
{

    return n1 + n2;

}

static float Dividir(float n1, float n2)
{

    return n1 / n2;

}

static float Subtracao(float n1, float n2)
{

    return n1 - n2;

}



Console.WriteLine($@"
Escolha sua operação: * para multiplicaçao
                      / para divisão
                      + para soma
                      - para subtração");
char operação = char.Parse(Console.ReadLine()!);

switch (operação)
{

    case '*':
        Console.WriteLine($"Insira dois numeros para multiplicar:");
        float resultado = Multiplicacao(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
        Console.WriteLine($"Resultado da sua Multiplicação: {resultado}");
        break;

    case '+':

        Console.WriteLine($"Insira dois numeros para sua soma:");
        float resultadosoma = Somar(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
        Console.WriteLine($"Resultado da sua Soma: {resultadosoma}");
        break;


    case '/':

        Console.WriteLine($"Insira dois numeros para sua divisão:");
        float resultadodiv = Dividir(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
        Console.WriteLine($"Resultado da sua Dividisão: {resultadodiv}");
        break;

    case '-':

        Console.WriteLine($"Insira dois numeros para sua subtração:");
        float resultadosub = Subtracao(float.Parse(Console.ReadLine()!), float.Parse(Console.ReadLine()!));
        Console.WriteLine($"Resultado da sua subtração: {resultadosub}");
        break;
    default:
    Console.WriteLine($"Opçao invalida");
    break;
    

}
