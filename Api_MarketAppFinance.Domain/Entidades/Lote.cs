using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class Lote : Base
    {
        #region Construtores
        private Lote()
        {
        }

        public Lote(string descricao, Empresa empresa, decimal peso, DateTime? dataFabricacao = null, DateTime? dataVcto = null, string? observacao = null, string? numeroLote = null, string? numeroEmbalagem = null)
        {
            Descricao = descricao;
            EmpresaId = empresa.Id;
            Ativo = true;
            Peso = peso;
            DataFabricacao = dataFabricacao;
            DataVencimento = dataVcto;  
            Observacao = observacao;
            NumeroLote = numeroLote;
            NumeroEmbalagem = numeroEmbalagem;

            Validar();
        }


        #endregion

        #region Atributos Públicos
        public string Descricao { get; private set; }

        public int EmpresaId { get; private set; }

        public bool Ativo { get; private set; }

        public DateTime? DataFabricacao { get; private set; }

        public DateTime? DataVencimento { get; private set; }

        public string? Observacao { get; private set; }

        public string? NumeroLote { get; private set; }

        public string? NumeroEmbalagem { get; private set; }

        public decimal Peso { get; private set; }

        public Empresa Empresa { get; private set; }

        #endregion

        #region Metodos Privados
        private void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }
        #endregion

        #region Metodos Publicos

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarDescricao(string descricao) 
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição.");

            Descricao = descricao;
        }

        public void AlterarDataFabricacao(DateTime data)
        {
            if (data > DateTime.Now)
                throw new Exception("Data de fabricação invalida.");

            DataFabricacao = data;
        }

        public void AlterarDataVencimento(DateTime data)
        {
            if (data < DateTime.Now)
                throw new Exception("Data de vencimento invalida.");

            DataVencimento = data;
        }

        public void AlterarObservacao(string observacao)
        {
            if (string.IsNullOrEmpty(observacao))
                throw new Exception("Obrigatório informar a observacao.");

            Observacao = observacao;
        }


        public void AlterarNumeroLote(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                throw new Exception("Obrigatório informar o número do lote.");

            NumeroLote = numero;
        }


        public void AlterarNumeroEmbalagem(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                throw new Exception("Obrigatório informar o número da embalagem.");

            NumeroEmbalagem = numero;
        }

        public void AlterarPeso(decimal peso)
        {
            if (peso <= 0)
                throw new Exception("Obrigatório informar o peso.");

            Peso = peso;
        }


        #endregion

    }
}
