// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.


float[] numeros= new float[15];

for (int i=0; i<numeros.Length; i++)
{
    Console.WriteLine($"Insira o {i + 1}º numero:");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Sua lista invertida é:");

for (int i = 14; i >= 0; i--)
{   
    
   Console.WriteLine($@" Valor do {i+1}º numero: {numeros[i]}");
   
}
