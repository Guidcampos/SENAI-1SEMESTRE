using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using console_mvc.Model;

namespace console_mvc.View
{
    public class ProdutoView
    {
        // método para exibir os dados da lista no console

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:C}");


            }
        }

       
        // método para cadastrar um novo produto pelo console, retornando o valor como produto
       
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preço: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);
            
            return novoProduto;

        }
    }
}