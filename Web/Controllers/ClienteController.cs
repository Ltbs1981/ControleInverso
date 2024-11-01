using ControleInverso.Core.Entidades;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Servicos;
using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;

namespace ControleInverso.Web.Controllers
{
    internal class ClienteController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public void AdicionaCliente(string nome, string nascimento, string email)
        {
            Cliente cliente = new Cliente(nome, nascimento, email);
            //_clienteService = new ClienteService(new ClienteRepositorio());
            _clienteService.AdicionaCliente(cliente);
        }
    }
}
