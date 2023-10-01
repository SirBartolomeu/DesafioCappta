using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Utils
{
    public static class Mensagens
    {

        public static string ErroFormatoPlanalto 
            = @"Por favor insira as dimensões do planalto ultilizando 
apenas números separados por espaço.
Ex:'5 5'.";

        public static string ErroFomartoPosicaoSonda 
            = @"Por favor insira a posição da sonda ultilizando
2 números e 1 letra separados por espaço. Ex:'1 4 N'.";

        public static string ErroFormatoComandosSonda 
            = @"Por favor insira aos comandos da sonda ultilizando
apenas as Letras LRM Ex:'LLMMR'.";

        public static string ErroInicioForaDoPlanalto
            = @"Sua sonda foi mandada para uma posição fora
do planalto, por favor enviar novamente";


    }
}
