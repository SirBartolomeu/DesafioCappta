using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Interfaces
{
    public interface IValidador
    {

        public void ValidarPlanalto();
        public void ValidarPosicaoSonda();
        public void ValidarComandosSonda();
    }
}
