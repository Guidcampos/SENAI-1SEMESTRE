using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fix_MVC.Model;
using fix_MVC;

namespace fix_MVC.Controller
{
    public class ControllerEventos
    {
        Evento e = new Evento();
        EventoView eView = new EventoView();

       
        public void ListarEventos()
        {
            List<Evento> eventos = e.Ler();
            eView.Listar(eventos);

        }

        public void CadastrarEvento()
        {
            e.Inserir(eView.Cadastrar());
   
        }
    }
}
