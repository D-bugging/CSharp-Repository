using ExemploInjecaoDependencia.Interfaces;

namespace ExemploInjecaoDependencia.Services
{
    class RecepcaoService : IRecepcaoService
    {
        public string Saudacao(string nome) => $"Hello, {nome}";
    }
}