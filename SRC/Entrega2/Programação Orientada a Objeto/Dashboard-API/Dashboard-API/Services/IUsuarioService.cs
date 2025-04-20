// Services/IUsuarioService.cs
using Dashboard_API.DTOs;
using Dashboard_API.Model;
using System.Threading.Tasks;

namespace Dashboard_API.Services
{
    public interface IUsuarioService
    {
        Task<Usuario> CadastrarUsuario(UsuarioDTO usuarioCadastro);
    }
}