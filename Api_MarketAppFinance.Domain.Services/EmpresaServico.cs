using Api_MarketAppFinance.Domain.Core.Interfaces.Services;
using Api_MarketAppFinance.Domain.Entities;
using Api_MarketAppFinance.Domain.Interrfaces.Repositories;

namespace Api_MarketAppFinance.Domain.Services
{
    public class EmpresaServico : ServicoBase<Empresa>, IEmpresaServico<Empresa>
    {
        #region Atributos
        private readonly IEmpresaRepositorio<Empresa> _repositorioEmpresa;
        #endregion

        #region Construtores
        public EmpresaServico(IEmpresaRepositorio<Empresa> repositorioEmpresa) : base(repositorioEmpresa)
        {
            _repositorioEmpresa = repositorioEmpresa;
        }
        #endregion

        #region Metodos Privados
        
        #endregion

        #region Metodos Publicos
        public Empresa AdicionarEmpresa(Empresa empresa)
        {
            var dadosEmpresa = new Empresa(
                razaoSocial: empresa.RazaoSocial,
                nomeFantasia: empresa.NomeFantasia,
                numeroDocumento: empresa.NumeroDocumento,
                telefone: empresa.Telefone,
                usuarioId: empresa.UsuarioId,
                imagem: empresa.Imagem
                );
            
            Adicionar(dadosEmpresa);
            return BuscarEmpresaPorDocumento(dadosEmpresa.RazaoSocial);
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
                        
            return dadosEmpresa;
        }        

        public Empresa BuscarEmpresaPorDocumento(string documento)
            => _repositorioEmpresa.BuscarEmpresaPorDocumento(documento);
        
        public Empresa BuscarDadosCompletoEmpresa(string documento)
            => _repositorioEmpresa.BuscarDadosCompletoEmpresa(documento);



        #endregion

    }
}