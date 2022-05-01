using GerenciadoDeTarefas.Dtos;
using GerenciadoDeTarefas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace GerenciadoDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        
        [HttpPost]
        [AllowAnonymous]
        public IActionResult SalvarUsuario([FromBody]Usuario usuario)
        {
            try
            {
               return Ok(usuario);
            }
            catch (Exception e)
            {
                _logger.LogError("Ocorreu um erro ao obter o usuario", e);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErroRespostaDto()
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Erro = "Ocorreu um erro ao obter o usuario, tente novamente!"
                });
            }
        }
    }
}
