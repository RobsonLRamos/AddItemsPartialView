using FormulárioTeste.Models;
using FormulárioTeste.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.ViewComponents.Prateleira
{
    public class IndustriaViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Industria industria)
        {
            return View("Default", new IndustriaViewModel(industria));
        }

    }
}
