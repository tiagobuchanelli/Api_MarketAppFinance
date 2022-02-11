using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class Produto : Base
    {
        #region Construtores

        private Produto()
        {
        }

        public Produto(
            string descricao,
            Categoria categoria,
            Empresa empresa,
            decimal valorVenda,
            string? descricaoVenda = null,
            SubCategoria? subCategoria = null,
            Classificacao? classificacao = null,
            Marca? marca = null,
            string? codBarras = null,
            string? codigoIdentificacao = null,
            decimal? percentualDesconto = null,
            decimal? valorDesconto = null,
            decimal? valorCusto = null,
            decimal? valorMinimoVenda = null,
            string? observacao = null,
            string? observacaoVenda = null,
            decimal? percentualLucro = null,
            decimal? aliquotaIcmsDentroUf = null,
            decimal? aliquotaIpi = null,
            decimal? altura = null,
            decimal? largura = null,
            decimal? pesoLiquido = null,
            decimal? pesoBruto = null,
            decimal? espessura = null,
            decimal? estoqueMinimo = null,
            bool? controlaEstoqueLote = null
            )
        {
            Descricao = descricao;
            CategoriaId = categoria.Id;
            EmpresaId = empresa.Id;
            Ativo = true;
            ValorVenda = valorVenda;
            DescricaoVenda = descricaoVenda;
            SubCategoriaId = subCategoria is null ? 0 : subCategoria.Id;
            ClassificacaoId = classificacao is null ? 0 : classificacao.Id;
            MarcaId = marca is null ? 0 : marca.Id;
            CodigoBarras = codBarras;
            CodigoIdentificacao = codigoIdentificacao;
            PercentualDesconto = percentualDesconto ?? 0;
            ValorDesconto = valorDesconto ?? 0;
            ValorCusto = valorCusto ?? 0;
            ValorMinimoVenda = valorMinimoVenda ?? 0;
            Observacao = observacao;
            ObservacaoVenda = observacaoVenda;
            PercentualLucro = percentualLucro ?? 0;
            AliquotaIcmsDentroUf = aliquotaIcmsDentroUf ?? 0;
            AliquotaIpi = aliquotaIpi ?? 0;
            Altura = altura ?? 0;
            Largura = largura ?? 0;
            PesoLiquido = pesoLiquido ?? 0;
            PesoBruto = pesoBruto ?? 0;
            Espessura = espessura ?? 0;
            EstoqueMinimo = estoqueMinimo ?? 0;
            ControlaEstoqueLote = controlaEstoqueLote ?? false;
        }

        #endregion Construtores

        #region Atributos Publicos

        public string Descricao { get; private set; }

        public string? DescricaoVenda { get; private set; }

        public int CategoriaId { get; private set; }

        public int SubCategoriaId { get; private set; }

        public int ClassificacaoId { get; private set; }

        public int MarcaId { get; private set; }

        public int EmpresaId { get; private set; }

        public bool Ativo { get; private set; }

        public decimal ValorVenda { get; private set; }

        public string? CodigoBarras { get; private set; }

        public string? CodigoIdentificacao { get; private set; }

        public decimal PercentualDesconto { get; private set; }

        public decimal ValorDesconto { get; private set; }

        public decimal ValorCusto { get; private set; }

        public decimal ValorMinimoVenda { get; private set; }

        public string? Observacao { get; private set; }

        public string? ObservacaoVenda { get; private set; }

        public decimal PercentualLucro { get; private set; }

        public decimal AliquotaIcmsDentroUf { get; private set; }

        public decimal AliquotaIpi { get; private set; }

        public decimal Altura { get; private set; }

        public decimal Largura { get; private set; }

        public decimal PesoLiquido { get; private set; }

        public decimal PesoBruto { get; private set; }

        public decimal Espessura { get; private set; }

        public decimal EstoqueMinimo { get; private set; }

        public bool ControlaEstoqueLote { get; private set; }

        public Categoria Categoria { get; private set; }

        public SubCategoria SubCategoria { get; private set; }

        public Empresa Empresa { get; private set; }

        public Marca Marca { get; private set; }

        public Classificacao Classificacao { get; private set; }

        #endregion Atributos Publicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao))
                throw new Exception("Obrigatório informar a descrição.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");

            if (CategoriaId == default)
                throw new Exception("Obrigatório informar uma categoria válida");
        }

        public void AlterarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição.");

            Descricao = descricao;
        }

        public void AlterarDescricaoVenda(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Obrigatório informar a descrição de venda.");

            DescricaoVenda = descricao;
        }

        public void AlterarCodigoBarras(string codigoBarras)
        {
            if (string.IsNullOrEmpty(codigoBarras))
                throw new Exception("Obrigatório informar um codigo de barras.");

            CodigoBarras = codigoBarras;
        }

        public void AlterarCodigoIdentificacao(string codigoIdentificacao)
        {
            if (string.IsNullOrEmpty(codigoIdentificacao))
                throw new Exception("Obrigatório informar um codigo de identificação.");

            CodigoIdentificacao = codigoIdentificacao;
        }

        public void AlterarObservacao(string obs)
        {
            if (string.IsNullOrEmpty(obs))
                throw new Exception("Obrigatório informar um codigo de observação.");

            Observacao = obs;
        }

        public void AlterarObservacaoVenda(string observacaoVenda)
        {
            if (string.IsNullOrEmpty(observacaoVenda))
                throw new Exception("Obrigatório informar um codigo de observação venda.");

            ObservacaoVenda = observacaoVenda;
        }

        public void AlterarCategoria(Categoria categoria)
        {
            if (categoria is null)
                throw new Exception("Obrigatório informar uma categoria válida.");

            CategoriaId = categoria.Id;
        }

        public void AlterarSubCategoria(SubCategoria subcategoria)
        {
            if (subcategoria is null)
                throw new Exception("Obrigatório informar uma Subcategoria válida.");

            SubCategoriaId = subcategoria.Id;
        }

        public void AlterarClassificacao(Classificacao classificacao)
        {
            if (classificacao is null)
                throw new Exception("Obrigatório informar uma Classificação válida.");

            ClassificacaoId = classificacao.Id;
        }

        public void AlterarMarca(Marca marca)
        {
            if (marca is null)
                throw new Exception("Obrigatório informar uma Marca válida.");

            MarcaId = marca.Id;
        }

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarValorVenda(decimal valorVenda)
        {
            if (valorVenda <= 0)
                throw new Exception("Obrigatório informar uma Valor de Venda válido.");

            ValorVenda = valorVenda;
        }

        public void AlterarPercentualDesconto(decimal prDesconto)
        {
            if (prDesconto <= 0)
                throw new Exception("Obrigatório informar uma percentual de desconto válido.");

            PercentualDesconto = prDesconto;
        }

        public void AlterarValorDesconto(decimal valorDesconto)
        {
            if (valorDesconto <= 0)
                throw new Exception("Obrigatório informar uma valor de desconto válido.");

            ValorDesconto = valorDesconto;
        }

        public void AlterarValorCusto(decimal custo)
        {
            if (custo <= 0)
                throw new Exception("Obrigatório informar uma valor de custo válido.");

            ValorCusto = custo;
        }

        public void AlterarValorMinimoVenda(decimal minVenda)
        {
            if (minVenda <= 0)
                throw new Exception("Obrigatório informar uma valor minimo de venda válido.");

            ValorMinimoVenda = minVenda;
        }

        public void AlterarPercentualLucro(decimal prLucro)
        {
            if (prLucro <= 0)
                throw new Exception("Obrigatório informar uma percentual de lucro válido.");

            PercentualLucro = prLucro;
        }

        public void AlterarAliquotaIcmsDentroUf(decimal alIcms)
        {
            if (alIcms <= 0)
                throw new Exception("Obrigatório informar uma percentual de lucro válido.");

            AliquotaIcmsDentroUf = alIcms;
        }

        public void AlterarAliquotaIpi(decimal ipi)
        {
            if (ipi <= 0)
                throw new Exception("Obrigatório informar uma percentual de ipi válido.");

            AliquotaIpi = ipi;
        }

        public void AlterarAltura(decimal altura)
        {
            if (altura <= 0)
                throw new Exception("Obrigatório informar uma altura válida.");

            Altura = altura;
        }

        public void AlterarLargura(decimal largura)
        {
            if (largura <= 0)
                throw new Exception("Obrigatório informar uma largura válida.");

            Largura = largura;
        }

        public void AlterarPesoLiquido(decimal pesoLiquido)
        {
            if (pesoLiquido <= 0)
                throw new Exception("Obrigatório informar peso liquido válido.");

            PesoLiquido = pesoLiquido;
        }

        public void AlterarPesoBruto(decimal pesoBruto)
        {
            if (pesoBruto <= 0)
                throw new Exception("Obrigatório informar peso bruto válido.");

            PesoBruto = pesoBruto;
        }

        public void AlteraEspessura(decimal espessura)
        {
            if (espessura <= 0)
                throw new Exception("Obrigatório informar espessura válida.");

            Espessura = espessura;
        }

        public void AlteraEstoqueMinimo(decimal estoqueMinimo)
        {
            if (estoqueMinimo <= 0)
                throw new Exception("Obrigatório informar estoque mínimo válido.");

            EstoqueMinimo = estoqueMinimo;
        }

        public void AlterarControlaEstoqueLote(bool controleEstoque) => ControlaEstoqueLote = controleEstoque;

        #endregion Metodos Publicos
    }
}