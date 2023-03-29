Console.WriteLine($"Informe sua idade:");
int idade = int.Parse(Console.ReadLine());

int meses = 12 * idade;
int dias = 365 * idade;
int horas = 24 * dias;
int minutos = 60 * horas;

Console.WriteLine($"Sua idade é {idade} anos, que é igual a : {meses} meses, {dias} dias, {horas} horas ou {minutos} minutos ");
