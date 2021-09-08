using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Models.ViewModels
{
    public class IndustriaViewModel
    {
        public IndustriaViewModel(Industria industria)
        {
            Industria = industria;
        }

        public Industria Industria { get; set; }
    }
}
