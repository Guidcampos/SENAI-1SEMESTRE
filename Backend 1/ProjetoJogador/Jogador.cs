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


        public void Cadastro()
        {
            Console.WriteLine($"Informe o nome do jogador:");
            this.nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Informe o ano de nascimento:");
            this.nasc = int.Parse(Console.ReadLine()!);
            Console.Clear();

            Console.WriteLine($"Informe o nacionalidade do jogador:");
            this.nacionalidade = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Informe a altura do jogador:");
            this.altura = float.Parse(Console.ReadLine()!);
            Console.Clear();

            Console.WriteLine($"Informe o peso do jogador: ");
            this.peso = float.Parse(Console.ReadLine()!);
            Console.Clear();
        }

        public void ImprimiJogador()
        {
            Console.WriteLine($@"
           --------------------------------------------------------
           
                        Nome: {this.nome}
                        Ano de nascimento: {this.nasc}
                        Nacionalidade: {this.nacionalidade}
                        Altura: {this.altura} metros
                        Peso: {this.peso} KG
                        Idade: {this.CalcIdade()} Anos

            --------------------------------------------------------
            
            ");
        }
        public int CalcIdade()
        {
            int idade = 2023 - this.nasc;

            return idade;
        }


        abstract public void Aposentar();

    }
}











