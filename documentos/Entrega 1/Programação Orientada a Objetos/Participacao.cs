public class Participacao {
        public int IdParticipacao;
        public int UsuarioId; 
        public Usuario Usuario; 

        public int EventoId; 
        public Evento Evento; 

        public string TokenIngresso;  // Token único gerado para controle de presença
        public bool Presenca;  // Será atualizado após leitura do token


    // Get e Set para IdParticipacao
    public int GetIdParticipacao()
    {
        return IdParticipacao;
    }
    public void SetIdParticipacao(int idParticipacao)
    {
        IdParticipacao = idParticipacao;
    }

    // Get e Set para UsuarioId
    public int GetUsuarioId()
    {
        return UsuarioId;
    }
    public void SetUsuarioId(int usuarioId)
    {
        UsuarioId = usuarioId;
    }

    // Get e Set para Usuario
    public Usuario GetUsuario()
    {
        return Usuario;
    }
    public void SetUsuario(Usuario usuario)
    {
        Usuario = usuario;
    }

    // Get e Set para EventoId
    public int GetEventoId()
    {
        return EventoId;
    }
    public void SetEventoId(int eventoId)
    {
        EventoId = eventoId;
    }

    // Get e Set para Evento
    public Evento GetEvento()
    {
        return Evento;
    }
    public void SetEvento(Evento evento)
    {
        Evento = evento;
    }

    // Get e Set para TokenIngresso
    public string GetTokenIngresso()
    {
        return TokenIngresso;
    }
    public void SetTokenIngresso(string tokenIngresso)
    {
        TokenIngresso = tokenIngresso;
    }

    // Get e Set para Presenca
    public bool GetPresenca()
    {
        return Presenca;
    }
    public void SetPresenca(bool presenca)
    {
        Presenca = presenca;
    }

        
    }

