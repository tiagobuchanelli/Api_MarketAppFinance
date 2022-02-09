using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {
            try
            {
                return Ok(_aplicacaoServico.BuscarTodos());
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
                return Ok(_aplicacaoServico.BuscarPorCodigo(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null) 
                    throw new Exception("Dados inválidos!");

                return Ok(_aplicacaoServico.Adicionar(cidadeDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null) 
                    throw new Exception("Dados inválidos!");

                return Ok(_aplicacaoServico.Atualizar(cidadeDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (cidadeDto is null || cidadeDto.Id <= 0) 
                    throw new Exception("Dados inválidos!");

                _aplicacaoServico.Excluir(cidadeDto);
                return Ok("Cidade Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}