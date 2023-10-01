using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Interfaces
{
    public interface IMoverComando
    {
        public Tuple<int,int> Executar(string direcao);

    }
}
