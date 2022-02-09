using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace Api_MarketAppFinance.Api.Controllers
{
    [Route("v1/empresa")]
    [ApiController]
    public class EmpresaController : Controller
    {
        #region Atributos Privados

        private readonly IEmpresaAplicacaoServico _applicacaoServico;

        #endregion

        #region Construtores

        public EmpresaController(IEmpresaAplicacaoServico aplicacaoServico)
        {
            _applicacaoServico = aplicacaoServico;
        }

        #endregion

        #region Metodos Publicos

        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> BuscarTodos()
        {           
            try
            {   
                return Ok(_applicacaoServico.BuscarTodos());                
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
                return Ok(_applicacaoServico.BuscarPorCodigo(id));
            }
           catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }        
        
        [Route("informacoes-empresa")]
        [HttpGet]
        [Authorize]
        public ActionResult<string> BuscarInformacoesEmpresa([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || string.IsNullOrEmpty(empresaDto.Documento))
                    throw new Exception("Dados inválidos!");

                return Ok(_applicacaoServico.BuscarInformacoesEmpresa(empresaDto.Documento));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public ActionResult Adicionar([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Documento is null) 
                    throw new Exception("Dados inválidos!");

                return Ok(_applicacaoServico.Adicionar(empresaDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Authorize]
        public ActionResult Atualizar([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Id <= 0) 
                    throw new Exception("Dados inválidos!");

                return Ok(_applicacaoServico.Atualizar(empresaDto));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Authorize]
        public ActionResult Excluir([FromBody] EmpresaDto empresaDto)
        {
            try
            {
                if (empresaDto is null || empresaDto.Id <= 0) 
                    throw new Exception("Dados inválidos!");

                _applicacaoServico.Excluir(empresaDto);
                return Ok("Empresa Removida com sucesso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        #endregion
    }
}