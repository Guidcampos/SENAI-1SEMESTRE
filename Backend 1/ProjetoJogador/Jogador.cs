// Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

namespace ProjetoJogador
{
    abstract public class Jogador
    {

        public string? nome { get; set; }
        public int nasc { get; set; }
        public string? nacionalidade { get; set; }
        public float altura { get; set; }
        public float peso { get; set; }
  

        abstract public void ImprimiJogador();
        abstract public void CalcIdade();
        abstract public void Aposentar();








//        abstract public void ImprimiJogador();
// //         

// //             Console.WriteLine($@"
            
// // --------------------------------------------------------   
                     
// //             Nome do jogador: {this.nome}
// //             Idade: {2023 - this.nasc}
// //             Nacionalidade: {this.nacionalidade}
// //             Altura: {this.altura}
// //             Peso: {this.peso}

// // --------------------------------------------------------  
// //             ");
            

        
    }
}