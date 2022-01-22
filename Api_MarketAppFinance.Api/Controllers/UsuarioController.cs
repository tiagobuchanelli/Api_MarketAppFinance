using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("[controller]")]
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

                _applicacaoServico.Adicionar(usuarioDto);
                return Ok("Usuário Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    return NotFound();

                _applicacaoServico.Atualizar(usuarioDto);
                return Ok("Usuário Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto is null)
                    return NotFound();

                _applicacaoServico.Excluir(usuarioDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}