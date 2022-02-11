using Api_MarketAppFinance.Testes.MapperMock;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Testes.Application.Servicos
{
    public class CidadeAplicacaoServico
    {
        private IMapper _mapper;

        public CidadeAplicacaoServico() => _mapper = new MockMapper().ObterMappers();
    }
}
