using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selecao.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selecao.Test.Application.Service
{
    [TestClass]
    public class CalculadorServiceTest
    {
        [TestMethod]
        public void DeveTruncarValor()
        {
            CalculadorService service = new CalculadorService();
            var valorTruncado = service.Truncar(200.123, 2);
            Assert.AreEqual(200.12, valorTruncado);
        }

        [TestMethod]
        public void DeveCalcularJuros()
        {
            double taxa = 0.01;
            var valor = 100;
            var meses = 5;
            CalculadorService service = new CalculadorService();
            var jurosCalculado = service.CalcularJuros(valor, taxa, meses);
            Assert.AreEqual(105.10, jurosCalculado);
        }
    }
}