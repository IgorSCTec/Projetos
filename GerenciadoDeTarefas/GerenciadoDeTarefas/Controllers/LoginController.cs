using GerenciadoDeTarefas.Dtos;
using GerenciadoDeTarefas.Models;
using GerenciadoDeTarefas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace GerenciadoDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : BaseController
    {
        private readonly ILogger<LoginController> _logger;
        private readonly string loginTeste = "teste@gmail.com";
        private readonly string senhaTeste = "Teste@123";
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
    {
            try
            {
                if ( requisicao == null
                    || string.IsNullOrEmpty(requisicao.Login) || string.IsNullOrWhiteSpace(requisicao.Login)
                    || string.IsNullOrEmpty(requisicao.Senha) || string.IsNullOrWhiteSpace(requisicao.Senha)
                    || requisicao.Login != loginTeste || requisicao.Senha != senhaTeste)
                {
                    return BadRequest(new ErroRespostaDto()
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Erro = "Parametros de entrada invalidos."
                    });
                }

                var usuarioTeste = new Usuario()
                {
                    Id = 1,
                    Nome = "Usuario de Teste",
                    Email = loginTeste,
                    Senha = senhaTeste
                };

                var token = TokenService.CriarToken(usuarioTeste);

                return Ok(new LoginRespostaDto() { 
                    Email = usuarioTeste.Email,
                    Nome = usuarioTeste.Nome,
                    Token = token
                });
            }
            catch (Exception e)
            {
                _logger.LogError($"Ocorreu um erro ao efetuar o login: {e.Message}", e);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto() { 
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu um erro ao efetuar o login, tente novamente!"
                });
            }
    }

    }
}
