using Api_MarketAppFinance.Application;
using Api_MarketAppFinance.Application.Dtos;
using Api_MarketAppFinance.Application.Mappers;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Domain.Services;
using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Api_MarketAppFinance.Testes
{
    public class CarteiraAplicacaoServicoTest
    {
        private IMapper _mapper;

        public CarteiraAplicacaoServicoTest() 
        {
            SetMapper();
        }

        private void SetMapper()
        {
            var _autoMapperProfile = new DtoParaEntidadeCarteira();
            var _autoMapperProfile2 = new EntidadeCarteiraParaDto();
            var _configuration = new MapperConfiguration(x =>
            {
                x.AddProfile(_autoMapperProfile);
                x.AddProfile(_autoMapperProfile2);
            }

            );
            _mapper = new Mapper(_configuration);
        }

        [Fact]
        public void Adicionar_Carteira_RetornarExcecaoNome()
        {
            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var excecao = Assert.Throws<Exception>(() => mockAplicacao.Adicionar(_mapper.Map<CarteiraDto>(new Carteira("", 0))));

            Assert.Equal("Obrigatório informar o nome.", excecao.Message);  
        }

        [Fact]
        public void Adicionar_Carteira_RetornarExcecaoEmpresa()
        {
            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var excecao = Assert.Throws<Exception>(() => mockAplicacao.Adicionar(_mapper.Map<CarteiraDto>(new Carteira("Dinheiro", 0))));

            Assert.Equal("Obrigatório informar uma empresa válida.", excecao.Message);
        }


        [Fact]
        public void Atualizar_Carteira_RetornarExcecao()
        {
            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();            
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);          
           

            var excecao = Assert.Throws<Exception>(() => mockAplicacao.Atualizar(_mapper.Map<CarteiraDto>(carteira)));

            Assert.Equal("Nenhuma carteira encontrada", excecao.Message);
        }

        [Fact]
        public void Atualizar_Carteira_RetornarCarteira()
        {
            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);
            
            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarPorCodigo(1,1)).Returns(carteira);
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var retorno = mockAplicacao.Atualizar(_mapper.Map<CarteiraDto>(carteira));

            Assert.True(retorno is not null);
        }

        [Fact]
        public void Atualizar_Carteira_RetornarCarteiraAlterada()
        {
            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarPorCodigo(1, 1)).Returns(carteira);
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            carteira.AlterarDescricao("Cheque");
            var retorno = mockAplicacao.Atualizar(_mapper.Map<CarteiraDto>(carteira));

            Assert.True(retorno.Descricao == "Cheque");
        }        

        [Fact]
        public void Buscar_Carteiras_RetornarCarteiras()
        {
            var lista = new List<Carteira>();
            lista.Add(new Carteira("Dinheiro", 1));
            lista.Add(new Carteira("Dinheiro2", 1));

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarCarteiras(1)).Returns(lista);
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var retorno = mockAplicacao.BuscarCarteiras(1);
            Assert.True(retorno.ToList().Count > 0);
        }

        [Fact]
        public void Buscar_Carteiras_RetornarExcecao()
        {
            var lista = new List<Carteira>();
            lista.Add(new Carteira("Dinheiro", 1));
            lista.Add(new Carteira("Dinheiro2", 1));

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarCarteiras(1)).Returns(lista); 
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var excecao = Assert.Throws<Exception>(() => mockAplicacao.BuscarCarteiras(2));

            Assert.Equal("Nenhuma carteira encontrada", excecao.Message);
        }

        [Fact]
        public void Buscar_Carteira_RetornarExcecao()
        {
            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarPorCodigo(1, 1)).Returns(carteira);
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var excecao = Assert.Throws<Exception>(() => mockAplicacao.BuscarPorCodigo(1, 2));

            Assert.Equal("Nenhuma carteira encontrada", excecao.Message);
        }

        [Fact]
        public void Buscar_Carteira_RetornarCarteira()
        {
            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);

            var mockRepositorio = new Mock<ICarteiraRepositorio<Carteira>>();
            mockRepositorio.Setup(x => x.BuscarPorCodigo(1, 1)).Returns(carteira);
            var mockServico = new CarteiraServico(mockRepositorio.Object);
            var mockAplicacao = new CarteiraAplicacaoServico(mockServico, _mapper);

            var retorno = mockAplicacao.BuscarPorCodigo(1, 1);

            Assert.True(retorno is not null);
        }
       
    }
}