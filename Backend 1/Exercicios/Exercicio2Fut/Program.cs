Console.WriteLine($"Quantidade de gols do time A: ");
int golsA = int.Parse (Console.ReadLine());

Console.WriteLine($"Quantidade de gols do time B: ");
int golsB = int.Parse (Console.ReadLine());

if (golsA == golsB){

    Console.WriteLine($"Time A = {golsA} Gols");
    Console.WriteLine($"Time B = {golsB} Gols");

    Console.WriteLine($"Fim de jogo, jogo EMPATADO!");
}

else if (golsA > golsB){
    Console.WriteLine($"Time A = {golsA} Gols");
    Console.WriteLine($"Time B = {golsB} Gols");

    Console.WriteLine($"Fim de jogo, vitoria do time A!");
}

else {
     Console.WriteLine($"Time A = {golsA} Gols");
    Console.WriteLine($"Time B = {golsB} Gols");

    Console.WriteLine($"Fim de jogo, vitoria do time B!");
}