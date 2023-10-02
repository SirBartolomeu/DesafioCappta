using Algoritimo.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Comando.Tests
{
    
    public class MoverComandoTests
    {
        [Fact]
        public void Executar()
        {
            MoverComando moverComando = new MoverComando();

            Assert.Equal(Tuple.Create(0, 1), moverComando.Executar("N"));
            Assert.Equal(Tuple.Create(1, 0), moverComando.Executar("E"));
            Assert.Equal(Tuple.Create(0, -1), moverComando.Executar("S"));
            Assert.Equal(Tuple.Create(-1, 0), moverComando.Executar("W"));

            var exception = Assert.Throws<FormatException>(() => moverComando.Executar("3"));
            Assert.Equal("Formato Incorreto", exception.Message);
        }
    }
}
