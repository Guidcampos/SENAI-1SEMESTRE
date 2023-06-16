using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer.infra;
using projeto_gamer.Models;

namespace projeto_gamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        // instanciando o objeto da classe context que tem acesso com o banco de dados
        Context c = new Context();

        // http//localhost/Equipe/Listar
        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            //recurso de MVC que utiliza de uma "mochila" que contem as listas das equipes e pode ser acessada a qualquer momento na view de equipe
            ViewBag.Equipe = c.Equipe.ToList();

               if(ViewBag.UserName == null)
            {
                return LocalRedirect ("~/Login/Login");
            }
           
            else
            {

            // retorna a view de equipe
            return View();

            }

        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            //    INICIO DA LOGICA PARA RECEBER IMAGEM


            if (form.Files.Count > 0)
            {

                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //gera o caminho completo até o caminho do arquivo(imagem - nome com extensão)
                var path = Path.Combine(folder, file.FileName);

                //using para que a instrução dentro dele seja encerrado assim que for executada

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            //fim da lógica de upload

            // metodo vem como string que foi alterado para imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            c.Equipe.Add(novaEquipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");

        }

        // METODO PARA EXCLUIR
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Equipe e = c.Equipe.First(e => e.IdEquipe == id);

            c.Equipe.Remove(e);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        // METODO PARA EDITAR

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {

            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Equipe e = c.Equipe.First(e => e.IdEquipe == id);

            ViewBag.Equipe = e;

               if(ViewBag.UserName == null)
            {
                return LocalRedirect ("~/Login/Login");
            }
           
            else
            {

            return View("Edit");

            }
      
        }


        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Equipe e)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = e.Nome;

            // upload da imagem da equipe nova, atualizada

            if (form.Files.Count > 0)
            {

                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            Equipe equipe = c.Equipe.First(x => x.IdEquipe == e.IdEquipe);

            equipe.Nome = novaEquipe.Nome;
            equipe.Imagem = novaEquipe.Imagem;

            c.Equipe.Update(equipe);

            c.SaveChanges();


            return LocalRedirect("~/Equipe/Listar");

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

    }
}












           

