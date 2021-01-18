using ExemploSemInjecaoDependencia.Services;

namespace ExemploSemInjecaoDependencia.Controllers
{
    public class RecepcaoController
    {
        public string Ola(string nome)
        {
            var service = new RecepcaoService();
            return service.Saudacao(nome);
        }
    }
}