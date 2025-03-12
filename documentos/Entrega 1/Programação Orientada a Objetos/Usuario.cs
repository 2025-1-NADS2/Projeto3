namespace Dashboard_API.Model
{
    public class Usuario
    {
        public int IdUsuario;
        public string Nome;
        public string Cpf;
        public string Email;
        public string Senha;
        public string? Profissao;

        // chama a enum com os tipos de usuários
        public TipoUsuario tipoUsuario;


        // relacionamento de um para muitos (1:N)
        public ICollection<Evento> Eventos;
        public ICollection<Participacao> Participacoes;


        // Get e Set para idUsuario
        public int GetIdUsuario()
        {
            return IdUsuario;
        }
        public void SetIdUsuario(int idUsuario)
        {
            IdUsuario = idUsuario;
        }
    
        // Get e Set para nome
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
    
        // Get e Set para cpf
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
    
        // Get e Set para email
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    
        // Get e Set para senha
        public string GetSenha()
        {
            return Senha;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    
        // Get e Set para Profissao
        public string? GetProfissao()
        {
            return Profissao;
        }
        public void SetProfissao(string? profissao)
        {
            Profissao = profissao;
        }
    
        // Get e Set para TipoUsuario
        public TipoUsuario GetTipoUsuario()
        {
            return tipoUsuario;
        }
        public void SetTipoUsuario(TipoUsuario ntipoUsuario)
        {
            tipoUsuario = ntipoUsuario;
        }
    
        // Get e Set para Eventos
        public ICollection<Evento> GetEventos()
        {
            return Eventos;
        }
        public void SetEventos(ICollection<Evento> eventos)
        {
            Eventos = eventos;
        }
    
        // Get e Set para Participacoes
        public ICollection<Participacao> GetParticipacoes()
        {
            return Participacoes;
        }
        public void SetParticipacoes(ICollection<Participacao> participacoes)
        {
            Participacoes = participacoes;
        }

    
    }

    // Enum que define os tipos de usuários
    public enum TipoUsuario
    {
        Administrador = 1,
        Colaborador = 2,
        UsuarioComum = 3
    }
}

