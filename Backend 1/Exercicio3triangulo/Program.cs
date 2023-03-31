Console.WriteLine($"Informar primeiro lado do triangulo: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informar segundo lado do triangulo: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informar terceiro lado do triangulo: ");
float lado3 = float.Parse(Console.ReadLine());


if (lado1 == lado2 && lado1 == lado3 ){
    Console.WriteLine($"Triangulo Equilátero!");
}

else if (lado1 == lado2 || lado1 == lado3 || lado3 == lado2 )
{
    Console.WriteLine($"Triângulo Isóscele");
    
}

else {
    Console.WriteLine($"Triângulo Escaleno");
    
}