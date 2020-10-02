using ExemploEntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ExemploEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LivroContext db = new LivroContext())
            {
                // db.Database.EnsureCreated(); // Cria o DB

                // INSERT
                /*db.Livros.Add(new Livro { Titulo = "Ready Player One", Autor = "Ernest Cline", AnoPublicacao = 2012 });
                db.Livros.Add(new Livro { Titulo = "O Nome do Vento", Autor = "Patrick Rothfuss", AnoPublicacao = 2009 });
                db.SaveChanges();
                */

                var teste = db.Livros.Where(x => x.LivroId == 1);

                // SELECT
                db.Livros.ForEachAsync(x => Console.WriteLine("Título: {0} | Autor: {1}", x.Titulo, x.Autor));
            }
        }
    }
}