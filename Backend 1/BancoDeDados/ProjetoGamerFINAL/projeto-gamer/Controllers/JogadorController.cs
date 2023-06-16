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
    public class JOGADORController : Controller
    {
        private readonly ILogger<JOGADORController> _logger;

        public JOGADORController(ILogger<JOGADORController> logger)
        {
            _logger = logger;
        }

        Context a = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = a.Jogador.ToList();
            ViewBag.Equipe = a.Equipe.ToList();

            if (ViewBag.UserName == null)
            {
                return LocalRedirect("~/Login/Login");
            }

            else
            {

                return View();

            }
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            a.Jogador.Add(novoJogador);

            a.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");

        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador e = a.Jogador.First(e => e.IdJogador == id);

            a.Jogador.Remove(e);

            a.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");


            Jogador e = a.Jogador.First(e => e.IdJogador == id);

            ViewBag.Jogador = e;
            ViewBag.Equipe = a.Equipe.ToList();

            if (ViewBag.UserName == null)
            {
                return LocalRedirect("~/Login/Login");
            }

            else
            {
                return View("Edit");
            }
        }





        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Jogador e)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = e.Nome;
            novoJogador.Email = e.Email;
            novoJogador.Senha = e.Senha;
            novoJogador.IdEquipe = e.IdEquipe;


            Jogador jogador = a.Jogador.First(x => x.IdJogador == e.IdJogador);

            jogador.Nome = novoJogador.Nome;
            jogador.Email = novoJogador.Email;
            jogador.Senha = novoJogador.Senha;
            jogador.IdEquipe = novoJogador.IdEquipe;




            a.Jogador.Update(jogador);

            a.SaveChanges();


            return LocalRedirect("~/Jogador/Listar");

        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}