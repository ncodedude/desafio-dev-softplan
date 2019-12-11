using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selecao.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selecao.Test.Application.Service
{
    [TestClass]
    public class TaxaServiceTest
    {
        [TestMethod]
        public void DeveRetornarTaxaDeJuros()
        {
            var taxaSetada = 0.01;
            TaxaService service = new TaxaService();
            var taxaRetornada = service.ObterTaxaDeJuros();
            Assert.AreEqual(taxaSetada, taxaRetornada);
        }
    }

}
