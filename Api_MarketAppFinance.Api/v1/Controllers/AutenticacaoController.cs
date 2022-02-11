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
        #region Metodos Privados

        private readonly IUsuarioAplicacaoServico _applicacaoServico;

        #endregion

        #region Construtores

        public AutenticacaoController(IUsuarioAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }
        #endregion

        #region Metodos Publicos

        [HttpPost]
        [Route("login")]
        public ActionResult Autenticar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto.Email is null)
                    throw new Exception("Erro ao logar usuário!");

                return Ok(_applicacaoServico.Autenticar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion



    }
}