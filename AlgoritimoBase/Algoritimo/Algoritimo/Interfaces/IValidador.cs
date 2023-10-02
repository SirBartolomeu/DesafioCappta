﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo.Interfaces
{
    public interface IValidador
    {

        public bool ValidarPlanalto();
        public bool ValidarPosicaoSonda();
        public bool ValidarComandosSonda();
    }
}
