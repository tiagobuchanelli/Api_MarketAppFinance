using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        #region Atributos Privados

        private readonly IUsuarioAplicacaoServico _applicacaoServico;

        #endregion

        #region Construtores

        public UsuarioController(IUsuarioAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }

        #endregion

        #region Metodos Publicos

        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {           
            try
            {   
                return Ok(_applicacaoServico.BuscarTodos());                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            try
            {
                return Ok(_applicacaoServico.BuscarPorCodigo(id));
            }
           catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    throw new Exception("Dados inválidos!");

                return Ok(_applicacaoServico.Adicionar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null || usuarioDto.Id <= 0)
                    throw new Exception("Dados inválidos!");

                return Ok(_applicacaoServico.Atualizar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null || usuarioDto.Id <= 0)
                    throw new Exception("Dados inválidos!");

                _applicacaoServico.Excluir(usuarioDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        #endregion
    }
}