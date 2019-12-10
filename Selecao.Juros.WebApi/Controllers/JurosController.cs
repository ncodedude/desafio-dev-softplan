using Microsoft.AspNetCore.Mvc;
using Selecao.Application.Interfaces;

namespace Selecao.CalculoJuros.WebApi.Controllers
{
    [ApiController]
    public class JurosController : ApiControllerBase
    {
        private readonly ICalculadorService _calculadorService;

        public JurosController(ICalculadorService calculadorService)
        {
            _calculadorService = calculadorService;
        }

        [HttpGet]
        [Route("calculajuros")]
        public IActionResult Get()
        {
            //_calculadorService.CalcularJuros(meses, taxa);
            return Response(null);
        }

        [HttpGet]
        [Route("showmethecode")]
        public IActionResult Get(int id)
        {
            return Response(null);
        }
    }
}
