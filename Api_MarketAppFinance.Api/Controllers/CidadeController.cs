using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CidadeController : Controller
    {
        private readonly ICidadeAplicacaoServico _aplicacaoServico;

        public CidadeController(ICidadeAplicacaoServico aplicacaoServico)
        {
            _aplicacaoServico = aplicacaoServico;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {
            return Ok(_aplicacaoServico.BuscarTodos());
        }

        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            return Ok(_aplicacaoServico.BuscarPorCodigo(id));
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null)
                    return NotFound();

                _aplicacaoServico.Adicionar(cidadeDto);
                return Ok("Usuário Cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null)
                    return NotFound();

                _aplicacaoServico.Atualizar(cidadeDto);
                return Ok("Usuário Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null)
                    return NotFound();

                _aplicacaoServico.Excluir(cidadeDto);
                return Ok("Usuário Removido com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}