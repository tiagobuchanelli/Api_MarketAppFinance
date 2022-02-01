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

        [HttpPost]
        [Route("codigo")]
        [Authorize]
        public ActionResult<string> BuscarPorCodigo([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try                
            {
                if (formaPagamentoDto is null || formaPagamentoDto.EmpresaId is null) return Ok("Nenhuma forma de pagamento encontrada!");

                if (string.IsNullOrEmpty(chaveApiEmpresa) || !_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                var formaPagamento = _aplicacaoServico.BuscarPorCodigo(formaPagamentoDto.Id);

                if (formaPagamento is null) return Ok("Nenhuma carteira encontrada!");

                return Ok(formaPagamento);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar forma de pagamento: " + "\n" + e.Message);
            }
        }


        [HttpPost]
        [Route("obter-formas-pagamento")]
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null) return NotFound("Erro ao buscar formas de pagamento!");
                
                if(string.IsNullOrEmpty(chaveApiEmpresa) || !_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(formaPagamentoDto.EmpresaId), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                IEnumerable<FormaPagamentoDto> formasPagamento = _aplicacaoServico.BuscarFormasPagamento(Convert.ToInt32(formaPagamentoDto.EmpresaId));

                if (!formasPagamento.Any()) return Ok("Nenhuma formas de pagamento encontrada!");

                return Ok(formasPagamento);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar forma de pagamento: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Empresa is null) return NotFound("Erro ao cadastrar forma de pagamento!");

                if (string.IsNullOrEmpty(chaveApiEmpresa) || !_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(formaPagamentoDto.Empresa.Id), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                return Ok(_aplicacaoServico.Adicionar(formaPagamentoDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar forma de pagamento: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Empresa is null) return NotFound("Erro ao cadastrar forma de pagamento!");

                if (string.IsNullOrEmpty(chaveApiEmpresa) || !_empresaAplicacaoServico.ValidarChaveApiEmpresa(Convert.ToInt32(formaPagamentoDto.Empresa.Id), chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                return Ok(_aplicacaoServico.Atualizar(formaPagamentoDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar forma de pagamento: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromHeader] string chaveApiEmpresa, [FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                if (formaPagamentoDto is null || formaPagamentoDto.Id <= 0 || formaPagamentoDto.Empresa is null) return NotFound("Erro ao excluir forma de pagamento!");

                if (string.IsNullOrEmpty(chaveApiEmpresa) || !_empresaAplicacaoServico.ValidarChaveApiEmpresa(formaPagamentoDto.Empresa.Id, chaveApiEmpresa))
                    return NotFound("Erro ao realizar a operação, verifique a chave API da empresa!");

                _aplicacaoServico.Excluir(formaPagamentoDto);
                return Ok("Forma de pagamento removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar forma de pagamento: " + "\n" + e.Message);
            }
        }
    }
}