namespace ControleInverso.Core.Entidades
{
    internal class Cliente
    {
        public Cliente(string nome, DateTime nascimento, string email)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
    }
}
