using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Models.ViewModels
{
    public class PreteleiraViewModel
    {
        public int id { get; set; }

        public Livro livro { get; set; }

        public Brinquedo brinquedo { get; set; }

        public List<Perguntas> perguntas { get; set; }

    }
}
