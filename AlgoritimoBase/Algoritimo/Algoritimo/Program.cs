using Algoritimo.Comandos;
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
            //sonda1.ExecutarComandos(strComandos);

            char[] comandos1 = strComandos.ToCharArray();

            for (int i = 0; i < comandos1.Length; i++)
            {

                if (comandos1[i] != 'M')
                {
                    //sonda1.Girar(comandos1[i].ToString());
                    sonda1.ExecutarComando(new GirarComando(comandos1[i].ToString()));
                }
                else
                {
                    //sonda1.Mover();

                    sonda1.ExecutarComando(new MoverComando());
                }
            }



            Console.WriteLine(sonda1.posicaoX + " " + sonda1.posicaoY + " " + sonda1.direcao);










            Sonda sonda2 = new Sonda(strPosicao2, planaltoX, planaltoY);
            //sonda2.ExecutarComandos(strComandos2);

            char[] comandos2 = strComandos2.ToCharArray();

            for (int i = 0; i < comandos2.Length; i++)
            {

                if (comandos2[i] != 'M')
                {
                    ////sonda2.Girar(comandos2[i].ToString());
                    sonda2.ExecutarComando(new GirarComando(comandos2[i].ToString()));
                }
                else
                {
                    //sonda2.Mover();
                    sonda2.ExecutarComando(new MoverComando());
                }
            }

            Console.WriteLine(sonda2.posicaoX + " " + sonda2.posicaoY + " " + sonda2.direcao);

        }
    }
}
