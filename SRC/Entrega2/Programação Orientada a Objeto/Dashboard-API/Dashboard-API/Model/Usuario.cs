using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dashboard_API.Model
{
    public class Usuario
    {
        // Propriedades com acesso direto (utilizando C# Auto-Properties)

        [Key] // Define a chave primária
        public int IdUsuario { get; set; }  // Identificador único do usuário

        public required string Nome { get; set; }  // Nome completo do usuário

        public required string Cpf { get; set; }  // CPF do usuário

        public required string Email { get; set; }  // E-mail de contato do usuário

        public required string Senha { get; set; }  // Senha de acesso do usuário

        public string? Profissao { get; set; }  // Profissão do usuário (opcional)

        // Relacionamento com a enum TipoUsuario, que define o tipo de usuário
        public TipoUsuario TipoUsuario { get; set; }  // Tipo de usuário (Administrador, Colaborador, UsuarioComum)

        // Relacionamentos de um para muitos (1:N) com outras classes
        public  ICollection<Evento> Eventos { get; set; } = new List<Evento>();// Eventos em que o usuário está participando ou é responsável

        public ICollection<Participacao> Participacoes { get; set; } = new List<Participacao>();   // Participações do usuário nos eventos


    }

    // Enum que define os tipos de usuários
    public enum TipoUsuario
    {
        Administrador = 1,
        Colaborador = 2,
        UsuarioComum = 3
    }
}
