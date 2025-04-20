// Controllers/UsuarioController.cs
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dashboard_API.Model;
using Dashboard_API.DTOs;
using Dashboard_API.Services;
// Assumindo que o serviço de cadastro estará aqui
// Para utilizar o DTO de cadastro
// Para utilizar o modelo Usuario

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    // Endpoint para cadastrar usuário
    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDTO usuarioCadastro)
    {
        if (usuarioCadastro == null)
        {
            return BadRequest("Dados inválidos");
        }

        var resultado = await _usuarioService.CadastrarUsuario(usuarioCadastro);

        if (resultado == null)
        {
            return BadRequest("Erro ao cadastrar o usuário");
        }

        return Ok(new { message = "Usuário cadastrado com sucesso!" });
    }
}