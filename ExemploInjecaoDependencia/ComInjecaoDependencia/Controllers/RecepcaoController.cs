using ExemploInjecaoDependencia.Interfaces;
using System;

namespace ExemploInjecaoDependencia.Controllers
{
    public class RecepcaoController
    {
        private readonly IRecepcaoService _recepcaoService;
        public RecepcaoController(IRecepcaoService recepcaoService)
        {
            _recepcaoService = recepcaoService ??
                throw new ArgumentNullException(nameof(recepcaoService));
        }
        public string Ola(string nome) => _recepcaoService.Saudacao(nome);
    }
}