namespace ControleInverso.Core.Contratos.Email
{
    internal interface IEmailService
    {
        void EnviaEmailBoasVindas(string de, string para, string corpo);

    }
}
