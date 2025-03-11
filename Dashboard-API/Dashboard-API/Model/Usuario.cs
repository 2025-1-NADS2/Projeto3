namespace Dashboard_API.Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string? Profissao { get; set; }

        // chama a enum com os tipos de usuários
        public TipoUsuario tipoUsuario { get; set; }


        // relacionamento de um para muitos (1:N)
        public ICollection<Evento> Eventos { get; set; }
        public ICollection<Participacao> Participacoes { get; set; }

    }

    // Enum que define os tipos de usuários
    public enum TipoUsuario
    {
        Administrador = 1,
        Colaborador = 2,
        UsuarioComum = 3
    }
}
