using System;
using System.ComponentModel.DataAnnotations; // Para o atributo Key
using Microsoft.EntityFrameworkCore; // Para o Entity Framework

namespace Dashboard_API.Model
{
    public class FotosEventos
    {
        // Propriedade para armazenar o ID da foto do evento
        [Key] // Define a chave primária
        public int IdFotos { get; set; }

        // Relacionamento com a classe Evento (Evento ao qual a foto pertence)
        public int EventoId { get; set; } // ID do evento (chave estrangeira)

        // Propriedade de navegação para o evento relacionado
        public required Evento Evento { get; set; } // Relacionamento com o Evento (muitas fotos para um evento)

        // URL da imagem, que pode ser usada para armazenar o caminho ou link da foto
        public required string UrlImagem { get; set; } // Caminho ou link para a imagem

    }

}

