namespace ProjetoJogador
{
    public class JogadorDEF : Jogador
    {
        public override void Aposentar()
        {
            int tempoAposentar = 40 - CalcIdade();
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