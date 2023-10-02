using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Algoritimo.Interfaces;
using Algoritimo.Utils;

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

        public void ValidarPlanalto()
        {
            Regex rx = new Regex(@"^\d+(\d+)?(\s\d+(\d+)?)$");

            if (!(rx.IsMatch(TamanhoPlanalto)))
            {
                Console.WriteLine(Mensagens.ErroFormatoPlanalto);
                Console.ReadKey();
                throw new FormatException(Mensagens.ErroFormatoPlanalto);
            }
        }

        public void ValidarPosicaoSonda()
        {
            Regex rx = new Regex(@"^\d+(\d+)?\s\d+(\d+)?\s\b[wnesWNES]?$");

            if (!(rx.IsMatch(Posicao)))
            {
                Console.WriteLine(Mensagens.ErroFomartoPosicaoSonda);
                Console.ReadKey();
                throw new FormatException(Mensagens.ErroFomartoPosicaoSonda);
            }
        }

        public void ValidarComandosSonda()
        {
            Regex rx = new Regex(@"^[lrmLRM]+$");

            if (!(rx.IsMatch(Comandos)))
            {
                Console.WriteLine(Mensagens.ErroFormatoComandosSonda);
                Console.ReadKey();
                throw new FormatException(Mensagens.ErroFormatoComandosSonda);
            }
        }
    }
}
