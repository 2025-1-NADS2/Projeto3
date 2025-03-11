namespace Dashboard_API.Model
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Objetivo { get; set; }
        public string PalavrasChave { get; set; } // Pode ser armazenado como JSON
        public DateTime DataInicio { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public string? Endereco { get; set; } // Opcional para eventos presenciais
        public ModalidadeEvento Modalidade { get; set; }
        public int Vagas { get; set; }
        public int TotalInscritos { get; set; }
        public StatusEvento Status { get; set; }

        public int ColaboradorId { get; set; }
        public Usuario Colaborador { get; set; }

        // relacionamento de um para muitos (1:N)
        public ICollection<Participacao> Participacoes { get; set; }
        public ICollection<FotosEventos> Fotos { get; set; }
    }

    public enum ModalidadeEvento
    {
        online,
        presencial
    }

    public enum StatusEvento
    {
        Planejado,
        EmAndamento,
        Finalizado
    }
}
