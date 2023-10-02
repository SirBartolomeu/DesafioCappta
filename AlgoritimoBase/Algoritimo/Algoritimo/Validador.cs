using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Algoritimo.Interfaces;

namespace Algoritimo
{
    public class Validador: IValidador
    {
        public string TamanhoPlanalto { get; private set; }
        public string Posicao { get; private set; }
        public string Comandos { get; private set; }

        public Validador(string tamanhoPlanalto, string posicao, string comandos)
        {
            TamanhoPlanalto = tamanhoPlanalto;
            Posicao = posicao;
            Comandos = comandos;
        }

        public bool ValidarPlanalto()
        {
            Regex rx = new Regex(@"^\d+(\d+)?(\s\d+(\d+)?)$");

            if (rx.IsMatch(TamanhoPlanalto))
            {
                return true;
            }

                return false;
        }

        public bool ValidarPosicaoSonda()
        {
            Regex rx = new Regex(@"^\d+(\d+)?\s\d+(\d+)?\s\b[wnesWNES]?$");

            if (rx.IsMatch(Posicao))
            {
                return true;
            }

                return false;
        }

        public bool ValidarComandosSonda()
        {
            Regex rx = new Regex(@"^[lrmLRM]+$");

            if (rx.IsMatch(Comandos))
            {
                return true;
            }

                return false;
        }
    }
}
