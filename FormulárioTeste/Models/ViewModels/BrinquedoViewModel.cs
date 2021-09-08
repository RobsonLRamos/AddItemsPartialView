using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Models.ViewModels
{
    public class BrinquedoViewModel
    {
        public BrinquedoViewModel(Brinquedo brinquedo)
        {
            this.brinquedo = brinquedo;
        }

        public Brinquedo brinquedo { get; set; }
    }
}
