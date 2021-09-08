using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulárioTeste.Models.ViewModels
{
    public class LivroViewModel
    {
        public LivroViewModel(Livro livro)
        {
            Livro = livro;
        }
                                            
        public Livro Livro { get; set; }
    }
}
