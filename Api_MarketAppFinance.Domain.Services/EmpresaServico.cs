using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class EmpresaServico : ServicoBase<Empresa>, IEmpresaServico<Empresa>
    {
        #region Atributos
        private readonly IEmpresaRepositorio<Empresa> _repositorioEmpresa;
        private readonly ILicencaRepositorio<Licenca> _licencaRepositorio;
        #endregion

        #region Construtores
        public EmpresaServico(IEmpresaRepositorio<Empresa> repositorioEmpresa, ILicencaRepositorio<Licenca> licencaRepositorio) : base(repositorioEmpresa)
        {
            _repositorioEmpresa = repositorioEmpresa;
            _licencaRepositorio = licencaRepositorio;
        }
        #endregion

        #region Metodos Privados
        private void GerarLicencaEmpresa(string descricao, string tipo,string numeroDocumentoEmpresa)
        {
            var licenca = new Licenca(
                descricao: descricao,
                tipo: tipo,
                numeroAcessosPermitido: 10,
                dataValidade: DateTime.Now.AddMonths(12),
                empresa: BuscarInformacoesEmpresa(numeroDocumentoEmpresa)
                );

            _licencaRepositorio.Adicionar(licenca);            

        }
        #endregion

        #region Metodos Publicos
        public Empresa AdicionarEmpresa(Empresa dadosEmpresa)
        {
            dadosEmpresa.Validar();

            Adicionar(dadosEmpresa);            
            GerarLicencaEmpresa("Licença Software", "Padrão", dadosEmpresa.NumeroDocumento);

            return BuscarInformacoesEmpresa(dadosEmpresa.NumeroDocumento);
        }

        public Empresa AtualizarEmpresa(Empresa empresa)
        {
            var dadosEmpresa = BuscarPorCodigo(empresa.Id);

            dadosEmpresa.AlterarRazãoSocial(empresa.RazaoSocial);                        
            dadosEmpresa.AlterarNomeFantasia(empresa.NomeFantasia);
            dadosEmpresa.AlterarNumeroDocumento(empresa.NumeroDocumento);
            dadosEmpresa.AlterarTelefone(empresa.Telefone);
            dadosEmpresa.AlterarImagem(empresa.Imagem);                       

            Atualizar(dadosEmpresa);

            return  BuscarInformacoesEmpresa(dadosEmpresa.NumeroDocumento);
        }        
        
        public Empresa BuscarInformacoesEmpresa(string documento)
            => _repositorioEmpresa.BuscarInformacoesEmpresa(documento);

        public void ValidarChaveApiEmpresa(int idEmpresa, string chave)
        {
            var dados = _repositorioEmpresa.BuscarPorCodigo(idEmpresa);

            if (dados is null || dados.ChaveApi != chave)
                throw new Exception("Erro ao realizar a operação, verifique a chave API da empresa!");                       
        }

        public List<Empresa> BuscarTodos()
        => _repositorioEmpresa.BuscarTodos();

        public Empresa BuscarPorCodigo(int codigo)
        => _repositorioEmpresa.BuscarPorCodigo(codigo);      


        #endregion

    }
}