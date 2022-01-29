using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class Cliente : Base
    {
        #region Constructos

        private Cliente()
        { }

        public Cliente(
            string nomeFantasia,
            string razaoSocial,
            Empresa empresa,
            string? telefone1 = null,
            string? telefone2 = null,
            string? imagem = null,
            string? rua = null,
            string? numero = null,
            string? cep = null,
            string? letra = null,
            string? complemento = null,
            string? bairro = null,
            string? email = null,
            string? observacao = null,
            string? numeroDocumento = null,
            decimal? valorMinimoVenda = null,
            decimal? valorLimiteVenda = null,
            decimal? prDesconto = null
            )
        {
            Nome = nomeFantasia;
            Sobrenome = razaoSocial;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            EmpresaId = empresa.Id;
            Ativo = true;
            Imagem = imagem;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Letra = letra;
            Complemento = complemento;
            Bairro = bairro;
            Email = email;
            Observacao = observacao;
            NumeroDocumento = numeroDocumento;
            ValorMinimoVenda = valorMinimoVenda ?? 0;
            ValorLimiteVenda = valorLimiteVenda ?? 0;
            PrDesconto = prDesconto ?? 0;

            Validar();
        }

        #endregion Constructos



        #region Actributes Public

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public bool Ativo { get; private set; }

        public string? Telefone1 { get; private set; }

        public string? Telefone2 { get; private set; }

        public string? Imagem { get; private set; }

        public int EmpresaId { get; private set; }

        public string? Rua { get; private set; }

        public string? Numero { get; private set; }

        public string? Cep { get; private set; }

        public string? Letra { get; private set; }

        public string? Complemento { get; private set; }

        public string? Bairro { get; private set; }

        public string? Email { get; private set; }

        public string? Observacao { get; private set; }

        public string? NumeroDocumento { get; private set; }

        public decimal ValorMinimoVenda { get; private set; }

        public decimal ValorLimiteVenda { get; private set; }

        public decimal PrDesconto { get; private set; }

        public Empresa Empresa { get; private set; }

        #endregion Actributes Public

        #region Private Methods

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Obrigatório informar o nome da empresa.");

            if (string.IsNullOrEmpty(Sobrenome))
                throw new Exception("Obrigatório informar o nome curto da empresa.");

            if (EmpresaId == default)
                throw new Exception("Obrigatório informar um usuário valido");
        }

        #endregion Private Methods

        #region Public Methods

        public void Ativar() => Ativo = true;

        public void Inativar() => Ativo = false;

        public void AlterarImagem(string imageCompany) => Imagem = imageCompany;

        public void AlterarTelefone1(string phone) => Telefone1 = phone;

        public void AlterarTelefone2(string phone) => Telefone2 = phone;

        public void AlterarRua(string rua) => Rua = rua;

        public void AlteraNumero(string numero) => Numero = numero;

        public void AlteraCep(string cep) => Cep = cep;

        public void AlteraLetra(string letra) => Letra = letra;
        
        public void AlteraComplemento(string complemento) => Complemento = complemento;

        public void AlteraBairro(string bairro) => Bairro = bairro;

        public void AlteraEmail(string email) => Email = email;

        public void AlteraObservacao(string obs) => Observacao = obs;

        public void AlteraNumeroDocumento(string doc) => NumeroDocumento = doc;

        public void AlterarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Obrigatório informar o nome.");

            Nome = nome;
        }

        public void AlterarSobreNome(string sobreNome)
        {
            if (string.IsNullOrEmpty(sobreNome))
                throw new Exception("Obrigatório informar o sobrenome.");

            Sobrenome = sobreNome;
        }

        public void AlteraValorMinimoVenda(decimal valor)
        {
            if (valor < 0)
                throw new Exception("Informe um valor válido.");
            ValorMinimoVenda = valor;
        }

        public void AlteraLimiteVenda(decimal valor)
        {
            if (valor < 0)
                throw new Exception("Informe um valor válido.");
            ValorLimiteVenda = valor;
        }

        public void AlteraDesconto(decimal valor)
        {
            if (valor < 0)
                throw new Exception("Informe um valor válido.");
            PrDesconto = valor;
        }

        #endregion Public Methods
    }
}