// Services/UsuarioService.cs
using Dashboard_API.DTOs;
using Dashboard_API.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dashboard_API.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Dashboard_API.Services
{
    // Classe de serviço responsável por conter a lógica de negócios relacionada ao usuário.
    // Aqui é onde implementamos o cadastro, validações, hash de senha, e outras operações que envolvem o modelo Usuario.
    public class UsuarioService : IUsuarioService
    {
        
        private readonly DashboardContext _context;
        private readonly IPasswordHasher<Usuario> _senhaHasher;

        public UsuarioService(DashboardContext context, IPasswordHasher<Usuario> senhaHasher)
        {
            _context = context;
            _senhaHasher = senhaHasher;
        }

        public async Task<Usuario> CadastrarUsuario(UsuarioDTO usuarioCadastro)
        {
            // Validação do DTO de entrada
            if (usuarioCadastro == null)
            {
                throw new ArgumentNullException(nameof(usuarioCadastro), "Os dados do usuário não podem ser nulos.");
            }

            // Criar uma instância de Usuario a partir do DTO
            var novoUsuario = new Usuario
            {
                Nome = usuarioCadastro.Nome,
                Cpf = GerarHashCpf(usuarioCadastro.Cpf),
                Email = usuarioCadastro.Email,
                Senha = "",
                Profissao = usuarioCadastro.Profissao,
                TipoUsuario = usuarioCadastro.TipoUsuario
            };

            // Hashing da senha
            novoUsuario.Senha = _senhaHasher.HashPassword(novoUsuario, usuarioCadastro.Senha);

            // Adicionar o novo usuário ao contexto do banco
            _context.Usuarios.Add(novoUsuario);

            // Salvar as mudanças no banco de dados
            await _context.SaveChangesAsync();

            return novoUsuario;
        }

        // Função para gerar o hash do CPF
        private string GerarHashCpf(string cpf)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(cpf));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}