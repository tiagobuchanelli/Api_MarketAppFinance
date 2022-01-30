using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/carteira")]
    [ApiController]
    public class CarteiraController : Controller
    {
        private readonly ICarteiraAplicacaoServico _aplicacaoServico;

        public CarteiraController(ICarteiraAplicacaoServico aplicacaoServico)
        {
            _aplicacaoServico = aplicacaoServico;
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            try
            {
                var carteira = _aplicacaoServico.BuscarPorCodigo(id);

                if (carteira is null) return Ok("Nenhuma carteira encontrada!");

                return Ok(carteira);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar carteira: " + "\n" + e.Message);
            }
        }


        [HttpPost]
        [Route("obter-carteiras")]
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos([FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null) return NotFound("Erro ao buscar carteiras!");

                IEnumerable<CarteiraDto> carteiras = _aplicacaoServico.BuscarCarteiras(Convert.ToInt32(carteiraDto.EmpresaId));

                if (!carteiras.Any()) return Ok("Nenhuma carteira encontrada!");

                return Ok(carteiras);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar carteira: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null) return NotFound("Erro ao cadastrar carteira!");

                return Ok(_aplicacaoServico.Adicionar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar carteira: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null) return NotFound("Erro ao atualizar carteira!");

                return Ok(_aplicacaoServico.Atualizar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao atualizar carteira: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Id <= 0) return NotFound("Erro ao excluir carteira!");
                 
                _aplicacaoServico.Excluir(carteiraDto);
                return Ok("Carteira Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao excluir carteira: " + "\n" + e.Message);
            }
        }
    }
}