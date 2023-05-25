namespace ProjetoJogador
{

    public class JogadorMEI : Jogador
    {
        public override void Aposentar()
        {
            int tempoAposentar = 38 - CalcIdade();
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