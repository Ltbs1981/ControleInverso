using ControleInverso.Core.Entidades;
using ControleInverso.Core.Contratos;
using ControleInverso.Core.Contratos.Repositorios;

namespace ControleInverso.Infra.Repositorios
{
    internal class ClienteRepositorio: IClienteRepositorio
    {
        public void AdicionaCliente(Cliente cliente)
        {

            //context.Set<Cliente>().Add(cliente);
            //context.SaveChanges();
        }

    }
}
