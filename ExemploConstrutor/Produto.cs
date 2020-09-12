using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExemploConstructor
{
    class Produto
    {
        private string _nome;
        private double _preco { get; set; }
        private int _quantidade { get; set; }

        #region Construtores e sobrecarga
        public Produto ()
        {
            _quantidade = 0;
        } // Default Constructor
        public Produto(string nome, double preco) : this() // : this() -> reaproveita atributos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5; // Por padrão Quantidade é zero, mas pode-se adquirir um valor default
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }
        #endregion

        // GET and SET Nome
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1) _nome = nome;
        }
        public string GetNome()
        {
            return _nome;
        }

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}