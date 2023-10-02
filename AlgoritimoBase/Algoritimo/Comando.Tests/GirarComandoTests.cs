using Algoritimo.Comandos;
using System;
using Xunit;

namespace Comando.Tests
{
    public class GirarComandoTests
    {

        [Fact]
        public void Executar()
        {
            GirarComando girarComandoEsquerda = new GirarComando("L");
            Assert.Equal("W", girarComandoEsquerda.Executar("N"));
            Assert.Equal("S", girarComandoEsquerda.Executar("W"));
            Assert.Equal("E", girarComandoEsquerda.Executar("S"));
            Assert.Equal("N", girarComandoEsquerda.Executar("E"));

            GirarComando girarComandoDireita = new GirarComando("R");
            Assert.Equal("E", girarComandoDireita.Executar("N"));
            Assert.Equal("S", girarComandoDireita.Executar("E"));
            Assert.Equal("W", girarComandoDireita.Executar("S"));
            Assert.Equal("N", girarComandoDireita.Executar("W"));

            var exception = Assert.Throws<FormatException>(() => girarComandoDireita.Executar("3"));

            Assert.Equal("Formato Incorreto", exception.Message);

        }

    }
}
