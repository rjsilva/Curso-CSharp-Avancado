﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Contato
    {
        public String Telefone { get; set; }

        public override string ToString()
        {
            return "Contato " + Telefone;
        }
    }

}
