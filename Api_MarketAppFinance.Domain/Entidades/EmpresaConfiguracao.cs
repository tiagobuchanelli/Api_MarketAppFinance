using Api_MarketAppFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Validar();
        }


        #endregion

        #region Atributos Públicos
        
        public int EmpresaId { get; private set; }

        public bool UsaControleLotes { get; private set; }

        public Empresa Empresa { get; private set; }
        
        #endregion

        #region Metodos Privados
        private void Validar()
        {           
            if (EmpresaId == default)
                throw new Exception("Obrigatório informar uma empresa válida");
        }
        #endregion

        #region Metodos Publicos
                
        #endregion

    }
}
