﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploJson.Serialization
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Empresa { get; set; }
        public List<Endereco> Endereco { get; set; }
    }
}
