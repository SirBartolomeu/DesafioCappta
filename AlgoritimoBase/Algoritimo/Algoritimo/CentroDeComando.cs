using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritimo.Comandos;
using Algoritimo.Interfaces;
using Algoritimo.Utils;


namespace Algoritimo
{
    public class CentroDeComando : ICentroDeComando
    {
        private string StrPlanalto { get; set; }
        private int PlanaltoX { get; set; }
        private  int PlanaltoY { get; set; }
        private int QuantidadeSondas { get; set; }
        private List<string> Inputs { get; set; } = new();

    public CentroDeComando()
        {
            DefinirQuantidadeDeSondas();
            DefinirPlanalto();
            DefinirPosicoesEComandos();
        }


        public void DefinirQuantidadeDeSondas()
        {
            Console.WriteLine("Quantas sondas deseja enviar?");
            try
            {
                QuantidadeSondas = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite um valor inteiro positivo");
                QuantidadeSondas = int.Parse(Console.ReadLine());
            }

        }

        public void DefinirPosicoesEComandos()
        {

            for (int i = 1; i <= QuantidadeSondas; i++)
            {
                Console.WriteLine("Insira a posição inicial da sonda n" + i.ToString() + " :");
                Inputs.Add(Console.ReadLine());
                Console.WriteLine("Insira os comandos da sonda n" + i.ToString() + " :");
                Inputs.Add(Console.ReadLine());
                i = i++;
            }

        }

        public void DefinirPlanalto()
        {
            Console.WriteLine("Insira o tamanho do planalto:");
            StrPlanalto = Console.ReadLine();
            string[] strCoordenadas = StrPlanalto.Split(" ");
            try 
            {
                PlanaltoX = Int32.Parse(strCoordenadas[0]);
                PlanaltoY = Int32.Parse(strCoordenadas[1]);
            }
            catch
            {
                Console.WriteLine(Mensagens.ErroFormatoPlanalto);
                Console.ReadKey();
                throw new FormatException(Mensagens.ErroFormatoPlanalto);
            }


        }

        public void EnviarSonda(string strPosicao, string strComandos, int planaltoX, int planaltoY)
        {
            Sonda sonda = new Sonda(strPosicao, planaltoX, planaltoY);
            char[] comandos = strComandos.ToCharArray();

            for (int i = 0; i < comandos.Length; i++)
            {
                if (comandos[i] != 'M')
                {
                    sonda.ExecutarComando(new GirarComando(comandos[i].ToString()));
                }
                else
                {
                    sonda.ExecutarComando(new MoverComando());
                }
            }
            Console.WriteLine(sonda.PosicaoX + " " + sonda.PosicaoY + " " + sonda.Direcao);
        }

        public void IniciarExploracao()
        {
            for (int i = 0; i < Inputs.Count; i++)
            {
                string strPosicao = Inputs[i];
                string strComandos = Inputs[i + 1];
                Validar(StrPlanalto, strPosicao, strComandos);
                EnviarSonda(strPosicao, strComandos, PlanaltoX, PlanaltoY);
                i++;

            }
        }

        private static void Validar(string strPlanalto, string strPosicao, string strComandos)
        {
            Validador validador = new Validador(strPlanalto, strPosicao, strComandos);

            validador.ValidarPlanalto();
            validador.ValidarPosicaoSonda();
            validador.ValidarComandosSonda();

        }
    }
}
