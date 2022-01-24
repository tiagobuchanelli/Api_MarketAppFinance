using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_MarketAppFinance.Domain.Core.Utils
{
    public class ConverterObjetoJson
    {
        private object _objeto;

        public ConverterObjetoJson(object objeto)
        {
            _objeto = objeto;        
        }

        public string? Converter()
        {
            string? dados = null;

            if (_objeto is not null)
                return JsonConvert.SerializeObject(_objeto,
                          Newtonsoft.Json.Formatting.None,
                          new JsonSerializerSettings
                          {
                              NullValueHandling = NullValueHandling.Ignore
                          });

            return dados;
        }
    }
}
