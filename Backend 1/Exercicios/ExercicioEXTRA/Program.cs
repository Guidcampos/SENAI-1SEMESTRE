int f;
int nant = 0;
int natual = 1;


for (int i = 0;  i < 14;  i++)
{
    f = nant + natual;
    Console.WriteLine(f);
    nant = natual;
    natual = f;
}