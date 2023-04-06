
// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

bool senhacerta = false;

do 
{

Console.WriteLine($"Insira seu nome:");
string nome = Console.ReadLine()!;

Console.WriteLine($"Insira sua senha:");
string senha = Console.ReadLine()!;

if (nome == senha)
{

Console.WriteLine($"Senha não pode ser igual ao nome de usuario");
senhacerta = true;
}

else
{
    senhacerta = false;
}


} while (senhacerta == true);