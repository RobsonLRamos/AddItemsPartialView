using FormulárioTeste.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using FormulárioTeste.Models;

namespace FormulárioTeste.Controllers
{
    public class PrateleiraController : Controller
    {
        PreteleiraViewModel model;
        public IActionResult Index()
        {
            model = new PreteleiraViewModel() ;

            model.brinquedo = new Models.Brinquedo();
            model.brinquedo.Industria = new Models.Industria();
            model.livro = new Models.Livro();
            model.livro.Autor = new Models.Autor();
            model.id = 10;

            ViewBag.perguntas = new List<Models.Perguntas>()
            {
              new Models.Perguntas(){ id=1,Descricao = "Quantos anos vc tem?", marcado = false},
              new Models.Perguntas(){ id=2,Descricao = "Vc é casado?", marcado = false},
              new Models.Perguntas(){ id=3,Descricao = "Vc tem filhos?", marcado = false},
              new Models.Perguntas(){ id=4,Descricao = "Onde vc mora?", marcado = false}
            };

            return View(model);
        }


        public IActionResult GravaDados(PreteleiraViewModel model)
        {
            return View("Index",model);

        }

        [HttpPost]
        public IActionResult AdicionaItens(Perguntas  perguntas)
        {

            return View("Index");
        }


        [HttpPost]
        public JsonResult SalvarDados(PreteleiraViewModel model)
        {
            dynamic data = new System.Dynamic.ExpandoObject();
            data.mensagem = "Puts deu certo";

            var teste = JsonSerializer.Serialize(data);
            return new JsonResult(teste);
        }
    }
}
