using Api_MarketAppFinance.Domain.Entities;

namespace Api_MarketAppFinance.Domain.Entidades
{
    public class EmpresaConfiguracao : Base
    {
        #region Construtores

        private EmpresaConfiguracao()
        {
        }

        public EmpresaConfiguracao(Empresa empresa, bool? usaControleLotes = null)
        {
            EmpresaId = empresa.Id;
            UsaControleLotes = usaControleLotes ?? false;
        }

        #endregion Construtores

        #region Atributos Públicos

        public int EmpresaId { get; private set; }

        public bool UsaControleLotes { get; private set; }

        public Empresa Empresa { get; private set; }

        #endregion Atributos Públicos

        #region Metodos Privados

        #endregion Metodos Privados

        #region Metodos Publicos

        public void Validar()
        {
            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }

        #endregion
    }
}