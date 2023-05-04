

namespace ExeCelular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public float Tamanho;
        public bool Ligado = false;


        public void Ligar()
        {
            
            Console.WriteLine($@"
        Celular ligando ...............
        
        
        LIGADO");

        this.Ligado = true;
            
        }

        public void Desligar()
        {
            Console.WriteLine($@"
            Celular desligando ............
            
            
            DESLIGADO");
            
            this.Ligado = false;
        }

        public void FazerLig()
        {
        
          Console.WriteLine($"{(this.Ligado ? "Realizando ligação ....." : "Não foi possivel realizar ligação, o celular está desligado")}");
          
        }
        public void EnviaSms()
        {
          Console.WriteLine($"{(this.Ligado ? "Enviando SMS ........." : "Não foi possivel enviar SMS, o celular está desligado")}");
          
        }




            
            

    }
}

// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.