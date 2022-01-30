using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/empresa")]
    [ApiController]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaAplicacaoServico _applicacaoServico;

        public EmpresaController(IEmpresaAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {           
            try
            {
                var empresas = _applicacaoServico.BuscarTodos();

                if (empresas is null) return Ok("Nenhuma empresa encontrada!");

                return Ok(empresas);                
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar empresa: " + "\n" + e.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<string> BuscarPorCodigo(int id)
        {
            try
            {
                var empresa = _applicacaoServico.BuscarPorCodigo(id);

                if (empresa is null) return Ok("Nenhuma empresa encontrada!");
                
                return Ok(empresa);
            }
           catch (Exception e)
            {
                return BadRequest("Erro ao buscar empresa: " + "\n" + e.Message);
            }
        }        
        
        [Route("informacoes-empresa")]
        [HttpGet]
        public ActionResult<string> BuscarInformacoesEmpresa([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || string.IsNullOrEmpty(empresaDto.Documento)) return NotFound("Erro ao buscar empresa!");

                var empresa = _applicacaoServico.BuscarInformacoesEmpresa(empresaDto.Documento);

                if (empresa is null) return Ok("Nenhuma empresa encontrada!");

                return Ok(empresa);
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao buscar empresa: " + "\n" + e.Message);
            }
        }

        [HttpPost]
        public ActionResult Adicionar([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Documento is null) return NotFound("Erro ao cadastrar empresa!");
                
                return Ok(_applicacaoServico.Adicionar(empresaDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao cadastrar empresa: " + "\n" + e.Message);
            }
        }

        [HttpPut]
        public ActionResult Atualizar([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Id <= 0) return NotFound("Erro ao atualizar empresa!");

                return Ok(_applicacaoServico.Atualizar(empresaDto));
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao atualizar empresa: " + "\n" + e.Message);
            }
        }

        [HttpDelete]
        public ActionResult Excluir([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Id <= 0) return NotFound("Erro ao excluir empresa!");

                _applicacaoServico.Excluir(empresaDto);
                return Ok("Empresa Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao excluir Empresa: " + "\n" + e.Message);
            }
        }
    }
}