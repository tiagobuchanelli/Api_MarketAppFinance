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
        {
            var empresas = _mapper.Map<IEnumerable<EmpresaDto>>(_servicoEmpresa.BuscarTodos());
            empresas.ToList().ForEach(x => x.UsuarioId = null);

            return empresas;
        }

        public EmpresaDto BuscarPorCodigo(int id)
        {
            var empresa = _mapper.Map<EmpresaDto>(_servicoEmpresa.BuscarPorCodigo(id));
            empresa.UsuarioId = null;

            return empresa;
        }

        public EmpresaDto BuscarEmpresaPorDocumento(string documento)
        {
            var empresa = _mapper.Map<EmpresaDto>(_servicoEmpresa.BuscarEmpresaPorDocumento(documento));
            empresa.UsuarioId = null;

            return empresa;

        }public EmpresaDto BuscarDadosCompletoEmpresa(string documento)
        {
            var empresa = _mapper.Map<EmpresaDto>(_servicoEmpresa.BuscarDadosCompletoEmpresa(documento));
            empresa.UsuarioId = null;
            if (empresa.Licencas is not null) empresa.Licencas.Empresa = null;

            return empresa;
        }

        public EmpresaDto Adicionar(EmpresaDto userDto)
        {
            var dadosEmpresa = _mapper.Map<EmpresaDto>(_servicoEmpresa.AdicionarEmpresa(_mapper.Map<Empresa>(userDto)));
            dadosEmpresa.UsuarioId = null;

            return dadosEmpresa;

        }

        public EmpresaDto Atualizar(EmpresaDto userDto)
        {
            var dadosEmpresa = _mapper.Map<EmpresaDto>(_servicoEmpresa.AtualizarEmpresa(_mapper.Map<Empresa>(userDto)));
            dadosEmpresa.UsuarioId = null;

            return dadosEmpresa;
        }

        public void Excluir(EmpresaDto userDto)
        => _servicoEmpresa.Excluir(_mapper.Map<Empresa>(userDto));

       
    }
}