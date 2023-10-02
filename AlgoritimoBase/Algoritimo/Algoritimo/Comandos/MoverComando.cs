using Algoritimo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Comandos
{
    public class MoverComando : IMoverComando
    {
        public int PosicaoX { get; private set; }

        public int PosicaoY { get; private set; }

        public MoverComando()
        {
        
        }

        public Tuple<int, int> Executar(string direcao)
        {
            PosicaoX = 0;
            PosicaoY = 0;

            switch (direcao)
            {
                case "N":
                    PosicaoY++;
                    break;
                case "S":
                    PosicaoY--;
                    break;
                case "E":
                    PosicaoX++;
                    break;
                case "W":
                    PosicaoX--;
                    break;
            }

            return Tuple.Create(PosicaoX, PosicaoY);
            
        }
    }
}
