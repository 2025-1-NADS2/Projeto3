using System;
using Dashboard_API.Model;

namespace Dashboard_API.DTOs
{
    // Objeto de Transferência de Dados
    // para transportar dados entre a API e o banco de dados
    public class UsuarioDTO
    {
        // Não tem IdUsuario (porque esse é gerado automaticamente no banco).
        public required string Nome { get; set; }
        public required string Cpf { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public string? Profissao { get; set; }
        public TipoUsuario TipoUsuario { get; set; } // Enum para tipo de usuário
    }
}
