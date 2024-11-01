using System;
using ControleInverso.Core.Entidades;
using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Core.Contratos.Email;
namespace ControleInverso.Servicos
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
private readonly IEmailService _emailService;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente GetCliente()
        {
            return new Cliente("nome", "dataNascimento", "email");
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
