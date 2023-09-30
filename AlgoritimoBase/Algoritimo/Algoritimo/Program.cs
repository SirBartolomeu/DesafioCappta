using System;

namespace Algoritimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TO-DO: Realizar loop para inputs
            //TO-DO: Validar inputs e tratar erros
            //TO-DO: Separar classes para desacoplar código - Design Patterns
            //TO-DO: Escrever  Testes

            #region INPUTS
            string strPlanalto = "5 5";
            string strPosicao = "1 2 N";
            string strComandos = "LMLMLMLMM";
            string strPosicao2 = "3 3 E";
            string strComandos2 = "MMRMMRMRRM";
            #endregion

            string[] strCoordenadas = strPlanalto.Split(" ");
            int planaltoX = Int32.Parse(strCoordenadas[0]);
            int planaltoY = Int32.Parse(strCoordenadas[1]);

            Sonda sonda1 = new Sonda(strPosicao, planaltoX, planaltoY);
            sonda1.ExecutarComandos(strComandos);
            Console.WriteLine(sonda1.posicaoX + " " + sonda1.posicaoY + " " + sonda1.direcao);

            Sonda sonda2 = new Sonda(strPosicao2, planaltoX, planaltoY);
            sonda2.ExecutarComandos(strComandos2);
            Console.WriteLine(sonda2.posicaoX + " " + sonda2.posicaoY + " " + sonda2.direcao);
        }
    }
}
