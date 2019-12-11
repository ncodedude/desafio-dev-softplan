using System;
using System.Collections.Generic;
using System.Text;

namespace Selecao.Application.Interfaces
{
    public interface ICalculadorService
    {
        double CalcularJuros(decimal valor, double juros, decimal meses);
    }
}
