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
                if (usuarioDto is null) return NotFound("Erro ao logar usuário!");

                var dadosUsuario = _applicacaoServico.Autenticar(usuarioDto);

                if (dadosUsuario is null) return NotFound("Usuário ou senha inválidos!");
                                
                return Ok(dadosUsuario);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar Usuário: " + "\n" + e.Message);
            }
        }

        
    }
}