using Algoritimo.Comandos;
using Algoritimo.Interfaces;
using System;

namespace Algoritimo
{
    public class Sonda
    {
        public int posicaoX { get; private set; }
        public int posicaoY { get; private set; }

        private int limiteX;
        private int limiteY;

        public string direcao { get; private set; }

        public Sonda(string localizacaoInicial, int planaltoX, int planaltoY)
        {
            string[] str = localizacaoInicial.Split(" ");
            posicaoX = Int32.Parse(str[0]);
            posicaoY = Int32.Parse(str[1]);
            direcao = str[2];

            //TO-DO: fazer verificação tamanho do planalto ao movimentar-se a sonda
            limiteX = planaltoX;
            limiteY = planaltoY;
        }

        public void Girar(string sentido)
        {
            switch (direcao)
            {
                case "N":
                    direcao = (sentido == "L") ? "W" : "E";
                    break;
                case "S":
                    direcao = (sentido == "L") ? "E" : "W";
                    break;
                case "E":
                    direcao = (sentido == "L") ? "N" : "S";
                    break;
                case "W":
                    direcao = (sentido == "L") ? "S" : "N";
                    break;
            }
        }

        public void Mover()
        {
            switch (direcao)
            {
                case "N":
                    posicaoY++;
                    break;
                case "S":
                    posicaoY--;
                    break;
                case "E":
                    posicaoX++;
                    break;
                case "W":
                    posicaoX--;
                    break;
            }
        }

        public void ExecutarComando(IGirarComando comando)
        {
            direcao = comando.Executar(direcao);

        }

        public void ExecutarComando(IMoverComando comando)
        {
            posicaoX = posicaoX + comando.Executar(direcao).Item1;
            posicaoY = posicaoY + comando.Executar(direcao).Item2;
        }

        //public void ExecutarComandos(string strComandos)
        //{
        //    char[] comandos = strComandos.ToCharArray();

        //    for (int i = 0; i < comandos.Length; i++)
        //    {

        //        if (comandos[i] != 'M')
        //        {
        //            Girar(comandos[i].ToString());
        //        }
        //        else
        //        {
        //            Mover();
        //        }
        //    }
        //}
    }
}
