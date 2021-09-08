using FormulárioTeste.Models;
using FormulárioTeste.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.ViewComponents.Prateleira
{
    public class LivroViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Livro livro)
        {
            return View("Default", new LivroViewModel(livro));
        }
    }
}
