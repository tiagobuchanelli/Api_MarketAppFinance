using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;
using Api_MarketAppFinance.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Api_MarketAppFinance.Testes
{
    public class CarteiraServicoTest
    {
        public CarteiraServicoTest() {}

        [Fact]
        public void Adicionar_Carteira_RetornarExcecaoNome()
        {
            var mockServico = new CarteiraServico(new Mock<ICarteiraRepositorio<Carteira>>().Object);

            var excecao = Assert.Throws<Exception>(() => mockServico.AdicionarCarteira(new Carteira("", 1)));

            Assert.Equal("Obrigatório informar o nome.", excecao.Message);  
        }

        [Fact]
        public void Adicionar_Carteira_RetornarExcecaoEmpresa()
        {
            var mockServico = new CarteiraServico(new Mock<ICarteiraRepositorio<Carteira>>().Object);

            var excecao = Assert.Throws<Exception>(() => mockServico.AdicionarCarteira(new Carteira("Dinheiro", 0)));

            Assert.Equal("Obrigatório informar uma empresa válida.", excecao.Message);
        }


        [Fact]
        public void Atualizar_Carteira_RetornarExcecao()
        {
            var mockServico = new CarteiraServico(new Mock<ICarteiraRepositorio<Carteira>>().Object);

            var carteira = new Carteira("Dinheiro", 1);
            var prop = typeof(Carteira).GetProperty(nameof(Carteira.Id));
            if (prop is not null) prop.SetValue(carteira, 1, null);

            var excecao = Assert.Throws<Exception>(() => mockServico.AtualizarCarteira(carteira));

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
            var retorno = mockServico.AtualizarCarteira(carteira);

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
            carteira.AlterarDescricao("Cheque");
            var retorno = mockServico.AtualizarCarteira(carteira);

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
            var retorno = mockServico.BuscarCarteiras(1);

            Assert.True(retorno.Count > 0);
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
            var excecao = Assert.Throws<Exception>(() => mockServico.BuscarCarteiras(2));

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
            var excecao = Assert.Throws<Exception>(() => mockServico.BuscarPorCodigo(1, 2));

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
            var retorno = mockServico.BuscarPorCodigo(1, 1);

            Assert.True(retorno is not null);
        }
    }
}