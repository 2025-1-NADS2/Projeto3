using System;
using System.ComponentModel.DataAnnotations; // Para o atributo Key
using Microsoft.EntityFrameworkCore; // Para o Entity Framework


namespace Dashboard_API.Model
{
    public class Participacao
    {
        // Propriedade para armazenar o ID único da participação
        [Key] // Define a chave primária
        public int IdParticipacao { get; set; } // Identificador da participação

        // Relacionamento com a classe Usuario (muitos participantes para um usuário)
        public int UsuarioId { get; set; } // ID do usuário (chave estrangeira)

        // Propriedade de navegação para o usuário que participou
        public required Usuario Usuario { get; set; } // Relacionamento com o usuário

        // Relacionamento com a classe Evento (muitos participantes para um evento)
        public int EventoId { get; set; } // ID do evento (chave estrangeira)

        // Propriedade de navegação para o evento no qual o usuário participou
        public required Evento Evento { get; set; } // Relacionamento com o evento

        // Token único gerado para controle de presença (por exemplo, um código QR ou token)
        public required string TokenIngresso { get; set; } // Token gerado para ingresso e controle de presença

        // Indicador de presença do participante (será atualizado após a leitura do token)
        public bool Presenca { get; set; } // Presença do participante no evento (true/false)
    }
}
