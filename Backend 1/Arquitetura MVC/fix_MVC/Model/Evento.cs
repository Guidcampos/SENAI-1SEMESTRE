using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fix_MVC.Model
{
    public class Evento
    {
        public string Nome {get; set;}
        public string Desc {get; set;}
        public string Data {get; set;}
    
         private const string PATH = "Database/Evento.csv";

        public Evento()
        {
      
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> Eventos = new List<Evento>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
               string[] atributos = item.Split(";");

               Evento p = new Evento();

               p.Nome = atributos[0];
               p.Desc = (atributos[1]);
               p.Data= (atributos[2]);

               Eventos.Add(p);
            }

            return Eventos;
        }

     
        public string PrepararLinhasCSV(Evento p)
        {
            return $"{p.Nome};{p.Desc};{p.Data}";
        }

      
        public void Inserir(Evento p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
            
        }
   }
}
    


    




    