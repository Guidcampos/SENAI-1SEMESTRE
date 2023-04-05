Console.WriteLine($"Quantas maças deseja: ");
int maca = int.Parse(Console.ReadLine());

if (maca > 12)
{
    Console.WriteLine($"Valor da sua compra é {(maca * 0.25).ToString("C")}");
}

else {
    Console.WriteLine($"Valor da sua compra é {(maca * 0.30).ToString("C")}");
};

