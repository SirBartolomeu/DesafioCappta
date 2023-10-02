using System;
using System.Collections.Generic;
using Xunit;

namespace Algoritimo.Tests
{
    public class AlgoritimoTest
    {
        [Fact]
        public void IniciarExploracao()
        {
            CentroDeComando centroDeComando = new CentroDeComando();

            centroDeComando.StrPlanalto = "5 5";
            centroDeComando.Inputs = new List<string>
              {
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };

            Assert.(centroDeComando.IniciarExploracao());

        }
    }
}
