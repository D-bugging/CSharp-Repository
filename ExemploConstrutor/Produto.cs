using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExemploConstructor
{
    class Produto
    {
        private string _nome;
        private double Preco { get; private set; }
        private int Quantidade { get; private set; }

        #region Construtores e sobrecarga
        public Produto ()
        {
            Quantidade = 0;
        } // Default Constructor
        public Produto(string nome, double preco) : this() // : this() -> reaproveita atributos
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5; // Por padrão Quantidade é zero, mas pode-se adquirir um valor default
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
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
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}