using ControleInverso.Core.Entidades;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Servicos;
using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;

namespace ControleInverso.Web.Controllers
{
    internal class ClienteController
    {
        private IClienteService _clienteService;
        public void AdicionaCliente(string nome, DateTime nascimento, string email)
        {
            Cliente cliente = new Cliente(nome, nascimento, email);

            _clienteService = new ClienteService(new ClienteRepositorio());
            _clienteService.AdicionaCliente(cliente);
        }
    }
}
