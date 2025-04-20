using System;
using System.Collections.Generic;
using System.Text.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; // Para o atributo Key
using Microsoft.EntityFrameworkCore; // Para o Entity Framework

namespace Dashboard_API.Model {
    public class Evento
    {
        [Key] // Define a chave primária
        public int IdEvento { get; set; }
        public required string Nome { get; set; }
        public required string Objetivo { get; set; }

        // Propriedade 'PalavrasChave' armazena o JSON como string no banco
        public required string PalavrasChave { get; set; }

        // Propriedade 'PalavrasChaveArray' é usada no código para acessar as palavras-chave como um array
        [NotMapped] // Não será mapeada para a tabela do banco
        public string[] PalavrasChaveArray
        {
            get => string.IsNullOrEmpty(PalavrasChave)
                   ? Array.Empty<string>()
                   : JsonSerializer.Deserialize<string[]>(PalavrasChave); // Desserializa o JSON em um array
            set => PalavrasChave = JsonSerializer.Serialize(value); // Serializa o array de volta para o formato JSON
        }

        public DateTime DataInicio { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public string? Endereco { get; set; } // Opcional para eventos online
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public int? NumEndereco { get; set; }
        public int? Cep { get; set; }
        public ModalidadeEvento Modalidade { get; set; }
        public int Vagas { get; set; }
        public int TotalInscritos { get; set; }
        public StatusEvento Status { get; set; }
        public int ResponsavelId { get; set; } // Pode ser colaborador ou admin
        public required Usuario Responsavel { get; set; }
        public string? BannerUrl { get; set; }

        // Relacionamentos
        public ICollection<Participacao> Participacoes { get; set; } = new List<Participacao>();
        public ICollection<FotosEventos> Fotos { get; set; } = new List<FotosEventos>();

    }

    public enum ModalidadeEvento
    {
        Presencial = 0,
        Online = 1,
        Hibrido = 2
    }

    public enum StatusEvento
    {
        Planejado = 0,
        EmAndamento = 1,
        Concluido = 2,
        Cancelado = 3
    }
}
