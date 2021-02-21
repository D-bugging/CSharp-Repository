using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploRequestWeb
{
    class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string DDD { get; set; }
        public string Siafi { get; set; }

        public override string ToString()
        {
            return "CEP: " + Cep
                + "\n Logradouro: " + Logradouro
                + "\n Complemento: " + Complemento
                + "\n Bairro: " + Bairro
                + "\n Localidade: " + Localidade
                + "\n UF: " + UF
                + "\n IBGE: " + Ibge
                + "\n GIA: " + Gia
                + "\n DDD: " + DDD
                + "\n Siafi: " + Siafi;
        }
    }
}