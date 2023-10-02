using Algoritimo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Comandos
{
    public class GirarComando : IGirarComando
    {          
        public string Sentido { get; private set; }

        public GirarComando(string sentido)
        {          
            Sentido = sentido;
        }

        public string Executar(string direcao)
        {
            switch (direcao)
            {
                case "N":
                    direcao = (Sentido == "L") ? "W" : "E";
                    break;
                case "S":
                    direcao = (Sentido == "L") ? "E" : "W";
                    break;
                case "E":
                    direcao = (Sentido == "L") ? "N" : "S";
                    break;
                case "W":
                    direcao = (Sentido == "L") ? "S" : "N";
                    break;
                default:
                    throw new FormatException("Formato Incorreto");
            }

            return direcao;
        }
    }
}
