using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo
{
    public class Sonda
    {
        public int posicaoX { get; set; }
        public int posicaoY { get; set; }

        private int limiteX;
        private int limiteY;

        public string direcao;

        public Sonda(int posicaoX, int posicaoY, int limiteX, int limiteY, string direcao)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            this.limiteX = limiteX;
            this.limiteY = limiteY;
            this.direcao = direcao;
        }

        public void VirarEsquerda() { }

        public void VirarDireita() { }

        public void Mover() { }


    }
}
