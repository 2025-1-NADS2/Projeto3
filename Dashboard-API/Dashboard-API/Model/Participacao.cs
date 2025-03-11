namespace Dashboard_API.Model
{
    public class Participacao
    {
        public int IdParticipacao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public string TokenIngresso { get; set; } // Token único gerado para controle de presença
        public bool Presenca { get; set; } // Será atualizado após leitura do token
    }
}
