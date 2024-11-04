using ControleInverso;
using ControleInverso.Web.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ControleInverso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuração de dependências
            var serviceCollection = new ServiceCollection();
            var startup = new Startup();
            startup.InjetandoDependencias(serviceCollection);

            // Construindo o ServiceProvider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Obtendo uma instância de ClienteController
            var clienteController = serviceProvider.GetRequiredService<ClienteController>();

            // Dados do novo cliente
            string nome = "Luciano Tadeu";
            string nascimento = "20/03/1981";
            string email = "lucianotadeubs@yahoo.com.br";

            // Adicionando cliente
            clienteController.AdicionaCliente(nome, nascimento, email);

            Console.WriteLine("Cliente adicionado com sucesso!");
        }
    }
}
