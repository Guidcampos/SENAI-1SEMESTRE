// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);

// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);

// Encapsular todos os atributos da classe (criar os métodos set e get).



namespace ExeElevador
{
    public class Elevador
    {
        public int andarTotal { get; set; }
        public int andarAtual { get; set; } = 0;
        public int capacTotal { get; set; }
        public int pessoas { get; set; } = 0;

        public void Inicializa(int capacTotal, int andarTotal)
        {
            // capacTotal = this.capacTotal;
            // andarTotal = this.andarTotal;

            // this.andarAtual = 0;
            // this.pessoas = 0;

            Console.WriteLine($"Seu elevador tem capacidade para {this.capacTotal} pessoas e tem {this.andarTotal} andares");


        }

        public void Entrar()
        {


            if (pessoas < capacTotal)
            {
                pessoas++;
                Console.WriteLine(@$"
                Uma pessoa entrou no elevador!
                Há {pessoas} pessoas dentro do elevador
                ");
            }
            else
            {
                Console.WriteLine($"O elevador está cheio!");
            }
        }

        public void Sair()
        {

            if (this.pessoas >= 2)
            {
                this.pessoas--;
                Console.WriteLine($@"
                Uma pessoa saiu do elevador!
                O elevador está com {this.pessoas} pessoas.");
                
             

            }

            else
            {
                pessoas = 0;
                 Console.WriteLine($"O elevador está vazio");

            }

        }

        public void Subir()
        {

            if (this.andarAtual < capacTotal)
            {
                this.andarAtual++;
                Console.WriteLine($"Você subiu um andar e agora está no {this.andarAtual}º andar");
            }
            else
            {
                Console.WriteLine($"Você ja está no último andar!");
            }


        }
        public void Descer()
        {
            // para descer um andar (não deve descer se já estiver no térreo);
            if (this.andarAtual >= 2)
            {
                this.andarAtual--;
                Console.WriteLine($"Você desceu um andar e agora está no {this.andarAtual }º andar");
            }
            else 
            {
                andarAtual = 0;
                Console.WriteLine($"Você ja está no térreo.");
            }

           

          


        }

    }
}









