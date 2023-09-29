using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuarioAsync(CreateUsuarioDto dto)
        {
            await usuarioService.CadastraAsync(dto);
            return Ok("Usuário Cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUsuarioDto dto)
        {
            var token = await usuarioService.LoginAsync(dto);
            return Ok(token);
        }
    }
}
