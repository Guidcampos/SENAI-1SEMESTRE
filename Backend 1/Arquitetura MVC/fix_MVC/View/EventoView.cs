using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fix_MVC.Model;



namespace fix_MVC
{
    public class EventoView
    {
    
        
         public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome: ");
            novoEvento.Nome = Console.ReadLine()!;
           
            Console.WriteLine($"Informe a descrição do evento: ");
            novoEvento.Desc = Console.ReadLine()!;
           
            Console.WriteLine($"Informe a data: dd/mm/aaaa ");
            novoEvento.Data = Console.ReadLine()!;
            
   

            return novoEvento;
            
        }

        public void Listar(List<Evento> eventos)
         {
            foreach (var item in eventos)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descrição: {item.Desc}");
                Console.WriteLine($"data: {item.Data}");
              
            }
        }

        public void Menu (){

            
        }

    }

        

            
}