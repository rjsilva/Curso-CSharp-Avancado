﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesoresPropriedadesStrutsEnum
{
    public enum Funcao
    {
        Programador, WebDesigner, Tester
    }
    public struct PessoaStruts
    {
        public String Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome : " + Nome);
            sb.AppendLine("Idade : " + Idade);

            return sb.ToString();
        }
    }
}
