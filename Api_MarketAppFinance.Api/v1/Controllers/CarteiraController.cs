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
        private readonly IEmpresaAplicacaoServico _empresaAplicacaoServico;

        public CarteiraController(ICarteiraAplicacaoServico aplicacaoServico, IEmpresaAplicacaoServico empresaAplicacaoServico)
        {
            _aplicacaoServico = aplicacaoServico;
            _empresaAplicacaoServico = empresaAplicacaoServico;
        }

        [HttpPost]
        [Route("codigo")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.EmpresaId is null) 
                    return NotFound("Erro ao buscar carteira!");

                if (!_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                var carteira = _aplicacaoServico.BuscarPorCodigo(Convert.ToInt32(carteiraDto.EmpresaId), carteiraDto.Id);

                if (carteira is null) 
                    return Ok("Nenhuma carteira encontrada!");
                
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
        public ActionResult<IEnumerable<string>> BuscarTodos([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null) 
                    return NotFound("Erro ao buscar carteiras!");

                if (!_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                IEnumerable<CarteiraDto> carteiras = _aplicacaoServico.BuscarCarteiras(Convert.ToInt32(carteiraDto.EmpresaId));

                if (!carteiras.Any()) 
                    return Ok("Nenhuma carteira encontrada!");

                return Ok(carteiras);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar carteira: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Empresa is null) 
                    return NotFound("Erro ao cadastrar carteira!");

                if (!_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(carteiraDto.Empresa.Id), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                return Ok(_aplicacaoServico.Adicionar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar carteira: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Empresa is null) 
                    return NotFound("Erro ao atualizar carteira!");

                if (!_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(carteiraDto.Empresa.Id), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                return Ok(_aplicacaoServico.Atualizar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao atualizar carteira: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Id <= 0 || carteiraDto.Empresa is null) 
                    return NotFound("Erro ao excluir carteira!");

                if (!_empresaAplicacaoServico.ValidarChaveApiEmpresa(carteiraDto.Empresa.Id, chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

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