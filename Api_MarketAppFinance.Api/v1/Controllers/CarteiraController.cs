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
        private readonly IEmpresaAplicacaoServico _empresaServico;

        public CarteiraController(ICarteiraAplicacaoServico aplicacaoServico, IEmpresaAplicacaoServico empresaAplicacaoServico)
        {
            _aplicacaoServico = aplicacaoServico;
            _empresaServico = empresaAplicacaoServico;
        }

        #region Metodos Privados
        private void ValidarAutorizacaoEmpresa(int idEmpresa, string chaveApi)
        {
            _empresaServico.Autorizacao(idEmpresa, chaveApi);
        }
        #endregion

        #region Metodos Publicos

        [HttpPost]
        [Route("codigo")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.EmpresaId is null) 
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa);               
                
                return Ok(_aplicacaoServico.BuscarPorCodigo(Convert.ToInt32(carteiraDto.EmpresaId), carteiraDto.Id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
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
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.BuscarCarteiras(Convert.ToInt32(carteiraDto.EmpresaId)));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.Adicionar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.Atualizar(carteiraDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromHeader] string chaveApiEmpresa, [FromBody] CarteiraDto carteiraDto)
        {
            try
            {
                if (carteiraDto is null || carteiraDto.Id <= 0 || carteiraDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(carteiraDto.EmpresaId), chaveApiEmpresa);

                _aplicacaoServico.Excluir(carteiraDto);
                return Ok("Carteira Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        #endregion
    }
}