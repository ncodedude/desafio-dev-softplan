using Selecao.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selecao.Application.Services
{
    public class CalculadorService : ICalculadorService
    {
        const int CASAS_DECIMAIS = 2;
        public double CalcularJuros(decimal valor, double juros, decimal meses)
        {
            double resultado = ((double)valor * Math.Pow(1 + juros, (double)meses));
            return Truncar(resultado, CASAS_DECIMAIS);
        }

        public double Truncar(double valor, int digitos)
        {
            decimal stepper = (decimal)(Math.Pow(10.0, (double)digitos));
            int temp = (int)(stepper * (decimal)valor);
            return  (double)(temp / stepper);
        }
    }
}
