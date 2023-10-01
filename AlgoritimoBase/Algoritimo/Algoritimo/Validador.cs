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

        public bool ValidaPlanalto()
        {
            Regex rx = new Regex(@"^\d+(\d+)?(\s\d+(\d+)?)$");

            if (rx.IsMatch(TamanhoPlanalto))
            {
                return true;
            }

                return false;
        }

        public bool ValidaPosicaoSonda()
        {
            Regex rx = new Regex(@"^\d+(\d+)?\s\d+(\d+)?\s\b[wnlsWNLS]?$");

            if (rx.IsMatch(Posicao))
            {
                return true;
            }

                return false;
        }

        public bool ValidaComandosSonda()
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
