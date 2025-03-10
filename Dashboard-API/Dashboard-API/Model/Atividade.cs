namespace Dashboard_API.Model
{
    public class Atividade
    {
        public int idAtividade { get; set; }
        public string nomeAtividade { get; set; }
        public string descricao { get; set; }
        public int projetoId { get; set; } // Chave estrangeira -> PROJETO
        public Projeto projeto { get; set; }
        public int colaboradorId { get; set; } // Chave estrangeira -> USUÁRIO
        public Usuario colaborador { get; set; }
        public DateTime dataCriacao { get; set; }

        // relacionamento de um para muitos (1:N)
        public ICollection<Entregas> entregas { get; set; }
    }
}
