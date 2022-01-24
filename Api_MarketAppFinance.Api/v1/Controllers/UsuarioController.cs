using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAplicacaoServico _applicacaoServico;

        public UsuarioController(IUsuarioAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {
            return Ok(_applicacaoServico.BuscarTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            return Ok(_applicacaoServico.BuscarPorCodigo(id));
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    return NotFound();
                
                var dadosUsuario = _applicacaoServico.Adicionar(usuarioDto);

                var dadosSerializados = new ConverterObjetoJson(dadosUsuario).Converter();
                                
                return Ok("Usuário Cadastrado com sucesso! \n" + dadosSerializados);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    return NotFound();

                var dadosUsuario = _applicacaoServico.Atualizar(usuarioDto);
                return Ok("Usuário Atualizado com sucesso! \n" + dadosUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    return NotFound();

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _applicacaoServico.Excluir(usuarioDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}