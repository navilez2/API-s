namespace ProjetoAPI.Model
{
    public class Usuario
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Lembrar_Email { get; set; }

    }
}
