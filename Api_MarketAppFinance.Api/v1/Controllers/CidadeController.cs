using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/cidade")]
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
            try
            {
                IEnumerable<CidadeDto> cidades = _aplicacaoServico.BuscarTodos();

                if (!cidades.Any()) return Ok("Nenhuma cidade encontrada!");

                return Ok(cidades);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar cidades: " + "\n" + e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            try
            {
                var cidade = _aplicacaoServico.BuscarPorCodigo(id);

                if (cidade is null) return Ok("Nenhuma cidade encontrada!");

                return Ok(cidade);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar cidade: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null) return NotFound("Erro ao cadastrar cidade!");

                return Ok(_aplicacaoServico.Adicionar(cidadeDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar cidade: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null) return NotFound("Erro ao atualizar cidade!");

                return Ok(_aplicacaoServico.Atualizar(cidadeDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao atualizar cidade: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null || cidadeDto.Id <= 0) return NotFound("Erro ao excluir cidade!");
                 
                _aplicacaoServico.Excluir(cidadeDto);
                return Ok("Cidade Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao excluir cidade: " + "\n" + e.Message);
            }
        }
    }
}