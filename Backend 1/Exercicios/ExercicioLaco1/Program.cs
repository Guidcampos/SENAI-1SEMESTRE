// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.



Console.WriteLine($"Por favor, insira sua nota");
float nota = float.Parse(Console.ReadLine()!);


while (nota < 0 || nota > 10) {

Console.WriteLine($"Nota invalida, insira novamente:");
nota = float.Parse(Console.ReadLine()!);

}