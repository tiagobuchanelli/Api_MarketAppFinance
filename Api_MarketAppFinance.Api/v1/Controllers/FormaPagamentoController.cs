using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/formas-pagamento")]
    [ApiController]
    public class FormaPagamentoController : Controller
    {
        private readonly IFormaPagamentoAplicacaoServico _aplicacaoServico;

        private readonly IEmpresaAplicacaoServico _empresaAplicacaoServico;

        public FormaPagamentoController(IFormaPagamentoAplicacaoServico aplicacaoServico, IEmpresaAplicacaoServico empresaAplicacaoServico)
        {
            _aplicacaoServico = aplicacaoServico;
            _empresaAplicacaoServico = empresaAplicacaoServico;
        }

        #region Metodos Privados
        private void ValidarAutorizacaoEmpresa(int idEmpresa, string chaveApi)
        {
            _empresaAplicacaoServico.Autorizacao(idEmpresa, chaveApi);
        }
        #endregion

        #region Metodos Publicos

        [HttpPost]
        [Route("codigo")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try                
            {
                if (formaPagamentoDto is null || formaPagamentoDto.EmpresaId is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.BuscarPorCodigo(Convert.ToInt32(formaPagamentoDto.EmpresaId), formaPagamentoDto.Id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("obter-formas-pagamento")]
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.BuscarFormasPagamento(Convert.ToInt32(formaPagamentoDto.EmpresaId)));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.Adicionar(formaPagamentoDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa);

                return Ok(_aplicacaoServico.Atualizar(formaPagamentoDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Id <= 0 || formaPagamentoDto.Empresa is null)
                    throw new Exception("Dados inválidos!");

                ValidarAutorizacaoEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa);

                _aplicacaoServico.Excluir(formaPagamentoDto);
                return Ok("Forma de pagamento removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        #endregion
    }
}