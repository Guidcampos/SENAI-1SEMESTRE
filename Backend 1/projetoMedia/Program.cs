Console.WriteLine($"Insira sua nota 1:");
float nota1 = float.Parse(Console.ReadLine());


Console.WriteLine($"Insira sua nota 2:");
float nota2 = float.Parse(Console.ReadLine());


Console.WriteLine($"Insira sua nota 3:");
float nota3 = float.Parse(Console.ReadLine());


Console.WriteLine($"Insira sua nota 4:");
float nota4 = float.Parse(Console.ReadLine());


Console.WriteLine($"Insira sua nota 5:");
float nota5 = float.Parse(Console.ReadLine());


float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine(@$"
Nota 1: {nota1}
Nota 2: {nota2}
Nota 3: {nota3}
Nota 4: {nota4}
Nota 5: {nota5}

Sua media final é: {media}
");




