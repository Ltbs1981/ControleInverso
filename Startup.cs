using ControleInverso.Core.Contratos.Email;

using ControleInverso.Core.Contratos.Repositorios;
using ControleInverso.Core.Contratos.Servicos;
using ControleInverso.Core.Entidades;
using ControleInverso.Infra.Repositorios;
using ControleInverso.Servicos;
using ControleInverso.Web.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace ControleInverso
{
    internal class Startup
    {
        public void InjetandoDependencias(IServiceCollection services)
        {
            //ServiceCollection service = new ServiceCollection();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ClienteController>();
        }
    }
}
