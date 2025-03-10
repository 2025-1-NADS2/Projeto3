namespace Dashboard_API.Model
{
    public class Participacoes
    {
        public int idParticipacoes { get; set; }
        public int usuarioId { get; set; } // Chave estrangeira -> Usuario
        public Usuario usuario { get; set; }
        public int projetoId { get; set; } // Chave estrangeira -> Projeto
        public Projeto projeto { get; set; }
        public double progresso { get; set; }
        public DateTime dataEntrada { get; set; }
    }
}
