using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/autenticacao")]
    [ApiController]
    public class AutenticacaoController : Controller
    {
        private readonly IUsuarioAplicacaoServico _applicacaoServico;

        public AutenticacaoController(IUsuarioAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }        

        [HttpPost]
        [Route("login")]
        public ActionResult Autenticar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto.Email is not null) 
                    return NotFound("Erro ao logar usuário!");

                return Ok(_applicacaoServico.Autenticar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
    }
}