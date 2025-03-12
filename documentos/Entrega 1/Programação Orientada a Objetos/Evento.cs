class Evento
    {
        public int IdEvento //{ get; set; }
        public string Nome //{ get; set; }
        public string Objetivo //{ get; set; }
        public string PalavrasChave //{ get; set; } // Pode ser armazenado como JSON
        public DateTime DataInicio //{ get; set; }
        public TimeSpan HoraInicio //{ get; set; }
        public DateTime DataFinal //{ get; set; }
        public TimeSpan HoraFinal //{ get; set; }
        public string? Endereco //{ get; set; } // Opcional para eventos presenciais
        public ModalidadeEvento Modalidade //{ get; set; }
        public int Vagas //{ get; set; }
        public int TotalInscritos //{ get; set; }
        public StatusEvento Status //{ get; set; }

        public int ColaboradorId //{ get; set; }
        public Usuario Colaborador //{ get; set; }

        // relacionamento de um para muitos (1:N)
        public ICollection<Participacao> Participacoes //{ get; set; }
        public ICollection<FotosEventos> Fotos //{ get; set; }


          // Gets e Sets 
        public int GetIdEvento()
        {
            return IdEvento;
        }
        public void SetIdEvento(int idEvento)
        {
            IdEvento = idEvento;
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetObjetivo()
        {
            return Objetivo;
        }
        public void SetObjetivo(string objetivo)
        {
            Objetivo = objetivo;
        }

        public string GetPalavrasChave()
        {
            return PalavrasChave;
        }
        public void SetPalavrasChave(string palavrasChave)
        {
            PalavrasChave = palavrasChave;
        }

        public DateTime GetDataInicio()
        {
            return DataInicio;
        }
        public void SetDataInicio(DateTime dataInicio)
        {
            DataInicio = dataInicio;
        }

        public TimeSpan GetHoraInicio()
        {
            return HoraInicio;
        }
        public void SetHoraInicio(TimeSpan horaInicio)
        {
           HoraInicio = horaInicio;
        }

        public DateTime GetDataFinal()
        {
            return DataFinal;
        }
        public void SetDataFinal(DateTime dataFinal)
        {
           DataFinal = dataFinal;
        }

        public TimeSpan GetHoraFinal()
        {
            return HoraFinal;
        }
        public void SetHoraFinal(TimeSpan horaFinal)
        {
            HoraFinal = horaFinal;
        }

        public string? GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string? endereco)
        {
            Endereco= endereco;
        }

        public ModalidadeEvento GetModalidade()
        {
            return Modalidade;
        }
        public void SetModalidade(ModalidadeEvento modalidade)
        {
            Modalidade = modalidade;
        }

        public int GetVagas()
        {
            return Vagas;
        }
        public void SetVagas(int vagas)
        {
            Vagas = vagas;
        }

        public int GetTotalInscritos()
        {
            return TotalInscritos;
        }
        public void SetTotalInscritos(int totalInscritos)
        {
            TotalInscritos = totalInscritos;
        }

        public StatusEvento GetStatus()
        {
            return Status;
        }
        public void SetStatus(StatusEvento status)
        {
            Status = status;
        }

        public int GetColaboradorId()
        {
            return ColaboradorId;
        }
        public void SetColaboradorId(int colaboradorId)
        {
            ColaboradorId = colaboradorId;
        }

        public Usuario GetColaborador()
        {
            return Colaborador;
        }
        public void SetColaborador(Usuario colaborador)
        {
            Colaborador = colaborador;
        }

        public ICollection<Participacao> GetParticipacoes()
        {
            return Participacoes;
        }
        public void SetParticipacoes(ICollection<Participacao> participacoes)
        {
            Participacoes = participacoes;
        }

        public ICollection<FotosEventos> GetFotos()
        {
            return Fotos;
        }
        public void SetFotos(ICollection<FotosEventos> fotos)
        {
            Fotos = fotos;
        }

        
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

