using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Selecao.CalculoJuros.WebApi.Controllers
{
    public abstract class ApiControllerBase : ControllerBase
    {
        protected IActionResult Response(object result = null)
        {
            return Ok(new
            {
                success = true,
                data = result
            });
        }
    }
}
