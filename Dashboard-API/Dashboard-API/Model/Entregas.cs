namespace Dashboard_API.Model
{
    public class Entregas
    {
        public int idEntrega { get; set; }
        public int usuarioId { get; set; } // Chave estrangeira -> USUÁRIO
        public Usuario usuario { get; set; }
        public int atividadeId { get; set; } // Chave estrangeira -> ATIVIDADE
        public Atividade atividade { get; set; }
        public string arquivoAnexo { get; set; }
        public DateTime dataEntrega { get; set; }
    }
}
