namespace ControleInverso.Core.Entidades
{
    internal class Cliente
    {
        
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string nascimento, string email)
        {
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

    }
}

