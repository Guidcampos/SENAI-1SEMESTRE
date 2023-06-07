using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_gamer.Models
{
    public class Jogador
    {
        // identificando o prime key
        [Key]
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        // identificando a foreign usando como parametro a classe equipe
        [ForeignKey("Equipe")]
        public int IdEquipe { get; set; }
        // invocando um objeto com nome equipe vindo da classe equipe
        public Equipe Equipe { get; set; }
    }
}

