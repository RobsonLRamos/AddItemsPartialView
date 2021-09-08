using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public Autor Autor { get; set; }

        public string Titulo { get; set; }
    }
}
