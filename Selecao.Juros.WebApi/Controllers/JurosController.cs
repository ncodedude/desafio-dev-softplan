using Microsoft.AspNetCore.Mvc;
using Selecao.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Selecao.CalculoJuros.WebApi.Controllers
{
    [ApiController]
    public class JurosController : ApiControllerBase
    {
        private readonly ICalculadorService _calculadorService;
        private readonly ITaxaService _taxaService;

        public JurosController(ICalculadorService calculadorService, ITaxaService taxaService)
        {
            _calculadorService = calculadorService;
            _taxaService = taxaService;
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<IActionResult> GetAsync(decimal valor, decimal meses)
        {
            var taxa = await _taxaService.ConsultarTaxaDeJurosAsync();
            return Response(_calculadorService.CalcularJuros(valor, taxa, meses));
        }

        [HttpGet]
        [Route("showmethecode")]
        public IActionResult Get()
        {
            return Response(Environment.GetEnvironmentVariable("URL_GITHUB"));
        }
    }
}
