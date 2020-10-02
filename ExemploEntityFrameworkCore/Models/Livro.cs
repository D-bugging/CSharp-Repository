using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEntityFrameworkCore
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
