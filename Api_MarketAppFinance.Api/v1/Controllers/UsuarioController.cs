using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
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
            try
            {
                var usuarios = _applicacaoServico.BuscarTodos();

                if (usuarios is null) return Ok("Nenhum usuário encontrado!");

                return Ok(usuarios);                
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar usuários: " + "\n" + e.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            try
            {
                var usuario = _applicacaoServico.BuscarPorCodigo(id);

                if (usuario is null) return Ok("Nenhum usuário encontrado!");

                return Ok(usuario);
            }
           catch (Exception e)
            {
                return BadRequest("Erro ao buscar usuário: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null) return NotFound("Erro ao cadastrar usuário!");
                
                return Ok(_applicacaoServico.Adicionar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar Usuário: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null || usuarioDto.Id <= 0) return NotFound("Erro ao atualizar usuário!");

                return Ok(_applicacaoServico.Atualizar(usuarioDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao atualizar Usuário: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null || usuarioDto.Id <= 0) return NotFound("Erro ao excluir usuário!");

                _applicacaoServico.Excluir(usuarioDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao excluir Usuário: " + "\n" + e.Message);
            }
        }
    }
}