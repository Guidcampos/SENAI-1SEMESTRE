

namespace ProjetoJogador
{
    public class JogadorATQ : Jogador
    {
        public override void Aposentar()
        {
            int tempoAposentar = 35 - CalcIdade();
            if (tempoAposentar <= 0)
            {
                Console.WriteLine($@"
            
            Jogador {this.nome} encontra-se aposentado");
            }
            else
            {
                Console.WriteLine($@"
            
            Faltam {tempoAposentar} anos para Jogador {this.nome} se aposentar");

            }
        }
    }
}
                   
            







