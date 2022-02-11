using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace MarketAppFinanceSApi_MarketAppFinanceervice.Application
{
    public class EmpresaAplicacaoServico : IEmpresaAplicacaoServico
    {
        private readonly IEmpresaServico<Empresa> _servicoEmpresa;
        private readonly IMapper _mapper;

        public EmpresaAplicacaoServico(IEmpresaServico<Empresa> servicoEmpresa, IMapper mapper)
        {
            _servicoEmpresa = servicoEmpresa;
            _mapper = mapper;
        }

        public IEnumerable<EmpresaDto> BuscarTodos()
        => _mapper.Map<IEnumerable<EmpresaDto>>(_servicoEmpresa.BuscarTodos());

        public EmpresaDto BuscarPorCodigo(int id)
        => _mapper.Map<EmpresaDto>(_servicoEmpresa.BuscarPorCodigo(id));

        public EmpresaDto BuscarInformacoesEmpresa(string documento)
        => _mapper.Map<EmpresaDto>(_servicoEmpresa.BuscarInformacoesEmpresa(documento));

        public EmpresaDto Adicionar(EmpresaDto empresaDto)
        {            
            if (empresaDto.Documento is not null && _servicoEmpresa.BuscarInformacoesEmpresa(empresaDto.Documento) is null)
                return _mapper.Map<EmpresaDto>(_servicoEmpresa.AdicionarEmpresa(_mapper.Map<Empresa>(empresaDto)));

            else
                throw new Exception("Empresa já cadastrada!");

        }

        public EmpresaDto Atualizar(EmpresaDto userDto)
        => _mapper.Map<EmpresaDto>(_servicoEmpresa.AtualizarEmpresa(_mapper.Map<Empresa>(userDto)));

        public void Excluir(EmpresaDto userDto)
        => _servicoEmpresa.Excluir(_mapper.Map<Empresa>(userDto));

        public void Autorizacao(int idEmpresa, string chave)
        => _servicoEmpresa.ValidarChaveApiEmpresa(idEmpresa, chave);
    }
}