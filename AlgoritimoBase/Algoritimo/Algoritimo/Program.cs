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
            //TO-DO: Realizar loop para mapear inputs e gerar sondas
            //TO-DO: Adicionar Estado(cod e msg) para comandos
            //TO-DO: Escrever  Testes
            //TO-DO: Escrever Diagrama de classes

            #region INPUTS
            //var inputs = new Dictionary<string, string>
            //{
            //    ["strPlanalto"] = strPlanalto,
            //    ["strPosicao1"] = strPosicao1,
            //    ["strComandos1"] = strComandos1,
            //    ["strPosicao2"] = strPosicao2,
            //    ["strComandos2"] = strComandos2,

            //};
            //string strPlanalto = Console.ReadLine();
            //string strPosicao = Console.ReadLine();
            //string strComandos = Console.ReadLine();
            //string strPosicao2 = Console.ReadLine();
            //string strComandos2 = Console.ReadLine();
            string strPlanalto = "5 5";
            string strPosicao1 = "1 2 N";
            string strComandos1 = "LMLMLMLMM";
            string strPosicao2 = "3 3 E";
            string strComandos2 = "MMRMMRMRRM";
            #endregion


            Validador validador = new Validador(strPlanalto, strPosicao1, strComandos1);
            
                if (!validador.ValidaPlanalto())
                {
                    Console.WriteLine(Mensagens.ErroFormatoPlanalto);
                    Console.ReadKey();
                    throw new FormatException();
                }
                if (!validador.ValidaPosicaoSonda())
                {   //TO-DO: Validar se está dentro do planalto
                    Console.WriteLine(Mensagens.ErroFomartoPosicaoSonda);
                    Console.ReadKey();
                    throw new FormatException();
                }
                if (!validador.ValidaComandosSonda())
                {
                    Console.WriteLine(Mensagens.ErroFormatoComandosSonda);
                    Console.ReadKey();
                    throw new FormatException();
                }
         

            string[] strCoordenadas = strPlanalto.Split(" ");
            int planaltoX = Int32.Parse(strCoordenadas[0]);
            int planaltoY = Int32.Parse(strCoordenadas[1]);

            Sonda sonda1 = new Sonda(strPosicao1, planaltoX, planaltoY);


            char[] comandos1 = strComandos1.ToCharArray();

            for (int i = 0; i < comandos1.Length; i++)
            {
                if (comandos1[i] != 'M')
                {
                    sonda1.ExecutarComando(new GirarComando(comandos1[i].ToString()));
                }
                else
                {
                    sonda1.ExecutarComando(new MoverComando());
                }
            }
            Console.WriteLine(sonda1.posicaoX + " " + sonda1.posicaoY + " " + sonda1.direcao);


            Sonda sonda2 = new Sonda(strPosicao2, planaltoX, planaltoY);

            char[] comandos2 = strComandos2.ToCharArray();

            for (int i = 0; i < comandos2.Length; i++)
            {

                if (comandos2[i] != 'M')
                {
                    sonda2.ExecutarComando(new GirarComando(comandos2[i].ToString()));
                }
                else
                {
                    sonda2.ExecutarComando(new MoverComando());
                }
            }

            Console.WriteLine(sonda2.posicaoX + " " + sonda2.posicaoY + " " + sonda2.direcao);

        }

    }
}
