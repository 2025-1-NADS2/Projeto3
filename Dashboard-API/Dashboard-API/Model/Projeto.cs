using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dashboard_API.Model
{
    public class Projeto
    {

        public int idProjeto { get; set; }
        public string nomeProjeto { get; set; }
        public string subDescricao { get; set; }
        public string descricaoCompleta { get; set; }
        public string palavrasChave { get; set; } 

        // chama a enum 
        public TipoProjeto tipoProjeto { get; set; }

        // nullable (?) Permite que um campo aceite null, ou seja, que ele possa ser opcional.
        public string? endereco { get; set; } 
        public int colaboradorId { get; set; } // chave estrangeira
        public Usuario Colaborador { get; set; } //  propriedade de navegação - permite acessar os dados completos do colaborador diretamente
        public int totalVagas { get; set; }
        public int inscritos { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFinal { get; set; }

        // relacionamento de um para muitos (1:N). Um Projeto pode ter muitas atividades e muitos participantes
        public ICollection<Atividade> Atividades { get; set; }
        public ICollection<Participacoes> Participacoes { get; set; }

    }

    // enum define um conjunto fixo de valores
    public enum TipoProjeto
    {
        Online,
        Presencial
    }
}
