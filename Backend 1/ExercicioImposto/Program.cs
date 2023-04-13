// //faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

using System.Globalization;

static float Imposto(float renda)
{

    float imposto;

    if (renda <= 1500 && renda > 0)
    {

        imposto = 0;

    }

    else if (renda > 1500 && renda <= 3500)
    {


        imposto = renda * 0.20F;

    }

    else if (renda > 3500 && renda <= 6000)
    {
        imposto = renda * 0.25F;


    }

    else
    {
        imposto = renda * 0.35F;


    }



    return imposto;

}


Console.WriteLine($"Informe sua renda:");
float valorenda = float.Parse(Console.ReadLine()!);

Console.WriteLine($@"
Sua renda: {valorenda.ToString("C", new CultureInfo("pt-BR"))} 
Seu imposto: {Imposto(valorenda).ToString("C", new CultureInfo("pt-BR"))} ");


