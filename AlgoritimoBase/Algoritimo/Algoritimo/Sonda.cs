using Algoritimo.Interfaces;
using Algoritimo.Utils;
using System;

namespace Algoritimo
{
    public class Sonda
    {
        public int PosicaoX { get; private set; }
        public int PosicaoY { get; private set; }
        public string Direcao { get; private set; }
        public int LimiteX { get; set; }
        public int LimiteY { get; set; }
        public bool IniciouMovimento { get; set; }


        public Sonda(string localizacaoInicial, int planaltoX, int planaltoY)
        {
            Pousar(localizacaoInicial);
            EstabelecerLimites(planaltoX, planaltoY);
            ChecarPosicao();
        }

        public void ExecutarComando(IGirarComando comando)
        {
            Direcao = comando.Executar(Direcao);
        }

        public void ExecutarComando(IMoverComando comando)
        {
            PosicaoX = PosicaoX + comando.Executar(Direcao).Item1;
            PosicaoY = PosicaoY + comando.Executar(Direcao).Item2;
            if(IniciouMovimento == false){
                IniciouMovimento = true;
            }
            ChecarPosicao();
        }

        private void ChecarPosicao()
        {
            if ((LimiteX < PosicaoX || LimiteY < PosicaoY) && !IniciouMovimento)
            {  
                Console.WriteLine(Mensagens.ErroInicioForaDoPlanalto);
                throw new ApplicationException(Mensagens.ErroInicioForaDoPlanalto);
            }
            if ((LimiteX < PosicaoX || LimiteY < PosicaoY) && IniciouMovimento)
            {
                Console.WriteLine(Mensagens.ErroMoveuForaDoPlanalto + PosicaoX + "," + PosicaoY);
                throw new ApplicationException(Mensagens.ErroMoveuForaDoPlanalto + PosicaoX + "," + PosicaoY);
            }
        }

        private void Pousar(string localizacaoInicial)
        {
            string[] str = localizacaoInicial.Split(" ");
            PosicaoX = Int32.Parse(str[0]);
            PosicaoY = Int32.Parse(str[1]);
            Direcao = str[2];
            IniciouMovimento = false;

        }

        private void EstabelecerLimites(int planaltoX, int planaltoY)
        {
            LimiteX = planaltoX;
            LimiteY = planaltoY;
        }

    }
}
