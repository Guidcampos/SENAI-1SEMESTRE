using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using console_mvc.Model;
using console_mvc.View;

namespace console_mvc.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // método controlador para acessar a listagem de produtos.
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
           
            // chamando a funcão inserir com o metodo cadastrar como paremetro de produto
          produto.Inserir(produtoView.Cadastrar());

            
        }
    }
}