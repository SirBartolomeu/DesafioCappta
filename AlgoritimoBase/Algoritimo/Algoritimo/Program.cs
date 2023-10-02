using Algoritimo.Comandos;
using Algoritimo.Interfaces;
using Algoritimo.Utils;
using System;
using System.Collections.Generic;

namespace Algoritimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO-DO: Adicionar Estado(cod e msg) para comandos
            //TO-DO: Escrever  Testes
            //TO-DO: Escrever Diagrama de classes
            #region Exemplo de Inputs
            //string strPlanalto; = "5 5";
            //string strPosicao1 = "1 2 N";
            //string strComandos1 = "LMLMLMLMM";
            //string strPosicao2 = "3 3 E";
            //string strComandos2 = "MMRMMRMRRM";
            #endregion

            CentroDeComando centroDeComando = new CentroDeComando();
            centroDeComando.IniciarExploração();

        }
    }
}
