using FormulárioTeste.Models;
using FormulárioTeste.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.ViewComponents.Prateleira
{
    public class BrinquedoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Brinquedo brinquedo)
        {
            return View("Default", new BrinquedoViewModel(brinquedo));
        }
    }
}
