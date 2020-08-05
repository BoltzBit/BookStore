using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("teste")]
    [Route("{action=Dados}")]
    public class TesteController : Controller
    {
        public ViewResult Dados(int? id, string nome)
        {
            var autor = new Autor
            {
                Id=0,
                Nome="Mateus"
            };

            ViewBag.Categoria = "Informatica";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Beleza";
            Session["Categoria"] = "Móveis";

            return View(autor);
        }

        //se a rota não for encontrada a padrão é renderezida
        //o padrao de busca é o Index
        //Sempre manter um padrão de nomes nas rotas
        public string Index(int Id)
        {
            return "Index do Id " + Id.ToString();
        }

        //quando o parametro é informado como int?, é um parametro nullable, não obrigatorio
        public JsonResult UmaAction(int? id, string nome)
        {

            var autor = new Autor {
                Id = 0,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }

        //rota decorada
        [Route("minharota/{id?}")]
        public string MinhaAction(int? id)
        {
            return "OK!";
        }

        //quando tem ~/ quer dizer que será ignorado o prefixo padrão em RoutePrefix()
        [Route("~/outra/{id:int}")]
        public string MinhaAction2(int id)
        {
            return "OK!!";
        }


        //parametri alpha, registringe valores alphanumericos, ou seja não aceita valores alphanumericos
        [Route("route/{categoria:alpha:minlength(3)}")]
        public string MinhaAction3(string categoria)
        {
            return "OK!!!!! " + categoria;
        }

        /*[Route("rota/{estacao:(primavera|verao|inverno|outono)}")]
        public string MinhaAction4(string estacao)
        {
            return "Ola estamos no " + estacao;
        }*/
    }
}