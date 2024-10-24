using System;
using ControleInverso.Core.Entidades;
using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;
using ControleInverso.Infra.Repositorios;
namespace ControleInverso.Servicos
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente GetCliente()
        {
            return new Cliente();
        }

        public void AdicionaCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                Console.WriteLine("Cliente invalido");
            }

            _clienteRepositorio.AdicionaCliente(cliente);
            //salva no banco 
            //Envia Email
        }

    }
}
