using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Selecao.Application.Interfaces
{
    public interface ITaxaService
    {
        double ObterTaxaDeJuros();
        Task<double> ConsultarTaxaDeJurosAsync();
    }
}
