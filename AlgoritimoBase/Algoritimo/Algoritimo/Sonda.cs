using Algoritimo.Interfaces;
using Algoritimo.Utils;
using System;

namespace Algoritimo
{
    public class Sonda
    {
        public int posicaoX { get; private set; }
        public int posicaoY { get; private set; }
        public string direcao { get; private set; }

        

        public Sonda(string localizacaoInicial, int planaltoX, int planaltoY)
        {
            string[] str = localizacaoInicial.Split(" ");
            posicaoX = Int32.Parse(str[0]);
            posicaoY = Int32.Parse(str[1]);
            direcao = str[2];

            int limiteX = planaltoX;
            int limiteY = planaltoY;

            if(limiteX > posicaoX || limiteY > posicaoY)
            {
                Console.WriteLine(Mensagens.ErroInicioForaDoPlanalto);
                throw new ApplicationException();
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

    }
}
