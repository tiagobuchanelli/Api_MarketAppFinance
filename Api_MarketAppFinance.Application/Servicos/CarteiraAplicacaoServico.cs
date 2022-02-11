using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Interfaces;
using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using AutoMapper;

namespace Api_MarketAppFinance.Application
{
    public class CarteiraAplicacaoServico : ICarteiraAplicacaoServico
    {
        private readonly ICarteiraServico<Carteira> _servicoCarteira;
        private readonly IMapper _mapper;

        public CarteiraAplicacaoServico(ICarteiraServico<Carteira> servicoCarteira, IMapper mapper)
        {
            _servicoCarteira = servicoCarteira;
            _mapper = mapper;
        }

        public CarteiraDto Adicionar(CarteiraDto carteira)
        {
            var dadosCarteira = _servicoCarteira.AdicionarCarteira(_mapper.Map<Carteira>(carteira));
            return _mapper.Map<CarteiraDto>(dadosCarteira);
        }

        public CarteiraDto Atualizar(CarteiraDto carteira)
        {
            var dadosCarteira = _servicoCarteira.AtualizarCarteira(_mapper.Map<Carteira>(carteira));
            return _mapper.Map<CarteiraDto>(dadosCarteira);
        }       

        public IEnumerable<CarteiraDto> BuscarCarteiras(int codigoEmpresa)
        => _mapper.Map<IEnumerable<CarteiraDto>>(_servicoCarteira.BuscarCarteiras(codigoEmpresa));

        public CarteiraDto BuscarPorCodigo(int idEmpresa, int id)
        => _mapper.Map<CarteiraDto>(_servicoCarteira.BuscarPorCodigo(idEmpresa, id));
                

        //public void Excluir(CarteiraDto carteiraDto)
        //=> _servicoCarteira.Excluir(_mapper.Map<Carteira>(carteiraDto));

        
    }
}