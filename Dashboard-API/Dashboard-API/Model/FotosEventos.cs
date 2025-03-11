namespace Dashboard_API.Model
{
    public class FotosEventos
    {
        public int IdFotos { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public string UrlImagem { get; set; }
    }
}
