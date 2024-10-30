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
            return new Cliente("Luciano", "28/03/1981", "lucianotadeubs@yahoo.com.br");
        }

        public void AdicionaCliente(Cliente cliente)
        {
            Console.WriteLine($"{cliente.Nome}, {cliente.Email}");
        _clienteRepositorio.AdicionaCliente(cliente);
            //salva no banco 
            //Envia Email
        }

    }
}
