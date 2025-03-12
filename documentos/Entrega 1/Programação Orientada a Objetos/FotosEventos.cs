namespace Dashboard_API.Model
{
    public class FotosEventos
    {
        public int IdFotos //{ get; set; }
        public int EventoId //{ get; set; }
        public Evento Evento //{ get; set; }

        public string UrlImagem //{ get; set; }


        public int GetIdFotos()
    {
        return IdFotos;
    }
    public void SetIdFotos(int idFotos)
    {
        IdFotos = idFotos;
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

    // Get e Set para UrlImagem
    public string GetUrlImagem()
    {
        return UrlImagem;
    }
    public void SetUrlImagem(string urlImagem)
    {
        UrlImagem = urlImagem;
    }

        
    }
}
