using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;
using ControleInverso.Core.Entidades;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Servicos;
using ControleInverso.Web.Controllers;

string nome = "Luciano Silva";
string nascimento = "28/03/1981";
string email = "luciano.silva@email.com";

Cliente novoCliente = new Cliente(nome, nascimento, email);

IClienteRepositorio clienteRepositorio = new ClienteRepositorio();
IClienteService clienteService = new ClienteService(clienteRepositorio);

// Adiciona o cliente
clienteService.AdicionaCliente(novoCliente);


Console.WriteLine("Cliente adicionado com sucesso!");

