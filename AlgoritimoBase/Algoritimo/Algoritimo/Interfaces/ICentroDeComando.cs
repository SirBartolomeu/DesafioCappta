using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Interfaces
{
    public interface ICentroDeComando
    {

        public void DefinirQuantidadeDeSondas();
        public void DefinirPosicoesEComandos();
        public void DefinirPlanalto();
        public void EnviarSonda(string strPosicao, string strComandos, int planaltoX, int planaltoY);     
        public void IniciarExploracao();
              
    }
}
