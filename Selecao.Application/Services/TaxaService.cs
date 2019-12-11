using Newtonsoft.Json;
using Selecao.Application.Interfaces;
using Selecao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Selecao.Application.Services
{
    public class TaxaService : ITaxaService
    {
        private HttpClient _httpClient = new HttpClient();
        private string _uri = Environment.GetEnvironmentVariable("TAXA_JUROS_API");
        //Implementação solicitada fixa no código.
        const double TAXA_JUROS = 0.01;
        public async Task<double> ConsultarTaxaDeJurosAsync()
        {
            TaxaApiResultado resultado = await ConsultarApi();
            return resultado.data;
        }

        public double ObterTaxaDeJuros()
        {
            return TAXA_JUROS;
        }

        private async Task<TaxaApiResultado> ConsultarApi()
        {
            HttpResponseMessage result = await _httpClient.GetAsync(_uri);
            string jsonResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TaxaApiResultado>(jsonResult);
        }
    }
}
