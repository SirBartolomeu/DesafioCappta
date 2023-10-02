using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Interfaces
{
    public interface ISonda
    {
        public void ExecutarComando(IGirarComando comando);
        public void ExecutarComando(IMoverComando comando);
        public void Pousar(string localizacaoInicial);

    }
}
