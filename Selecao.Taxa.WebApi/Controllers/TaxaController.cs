using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Selecao.Application;

namespace Selecao.TaxaJuros.WebApi.Controllers
{
    
    [ApiController]
    public class TaxaController : ApiControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public IActionResult Get()
        {
            return Response(null);
        }
    }
}
