using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Selecao.Application.Interfaces;

namespace Selecao.TaxaJuros.WebApi.Controllers
{
    
    [ApiController]
    public class TaxaController : ApiControllerBase
    {
        private readonly ITaxaService _taxaService;
        public TaxaController(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        [HttpGet]
        [Route("taxaJuros")]
        public IActionResult Get()
        {
            return Response(_taxaService.ObterTaxaDeJuros());
        }
    }
}
