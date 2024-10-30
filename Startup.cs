using ControleInverso.Core.Contratos.Email;

using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;
using ControleInverso.Core.Entidades;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace ControleInverso
{
    internal class Startup
    {
        public void InjetandoDependencias()
        {
            ServiceCollection service = new ServiceCollection();
            service.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            service.AddScoped<IClienteService, ClienteService>();
            service.AddScoped<IEmailService, EmailService>();

        }
    }
}
