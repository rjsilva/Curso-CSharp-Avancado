using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class ClienteVip:Cliente
    {
        public String Tipo { get; set; }

        public ClienteVip(String nome, int idade, int codigo)
        :base(nome,idade,codigo)
        {

        }

        public override string ToString()
        {
            return "Tipo Cliente " + Tipo + " Nome " + Nome + " Idade " + Idade + " Código " + Codigo;
        }
    }
}
