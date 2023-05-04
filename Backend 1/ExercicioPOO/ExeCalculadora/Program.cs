// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using ExeCalculadora;

Calculadora calc = new Calculadora();

Console.WriteLine($"Informe o primeiro numero:");
calc.n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe o segundo numero:");
calc.n2 = float.Parse(Console.ReadLine()!);

int n = 1;

do
{

    Console.WriteLine($@"
    
         Escolha uma operação: 
           
            + para somar
            - para subtrair
            / para dividir
            * para multiplicar 
            
            
            ");

    string escolha = Console.ReadLine()!;



    switch (escolha)
    {
        case "+":
            Console.WriteLine($"O resultado da operação é: {calc.Somar()}");
            n = 1;
            break;
             
        case "-":
            Console.WriteLine($"O resultado da operação é: {calc.Subtrair()}");
            n = 1;
            break;
            
        case "/":
            Console.WriteLine($"O resultado da operação é: {calc.Dividir()}");
            n = 1;
            break;

        case "*":
            Console.WriteLine($"O resultado da operação é: {calc.Multiplicar()}");
            n = 1;
            break;
            
        default:
            Console.WriteLine($"Opcao invalida");
            n = -1;
            break;
    }
} while (n < 0);

          




         


