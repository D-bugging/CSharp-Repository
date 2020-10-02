using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploEntityFrameworkCore.Context
{
    public class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection String
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCore.Demo;Trusted_Connection=True;");
        }

        // Modelagem
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livro"); // Nome para tabela especificando entidade
            modelBuilder.Entity<Livro>().HasKey(p => p.LivroId); // Primary Key
            modelBuilder.Entity<Livro>().Property(p => p.Titulo).HasColumnType("varchar(50)");
        }
    }
}