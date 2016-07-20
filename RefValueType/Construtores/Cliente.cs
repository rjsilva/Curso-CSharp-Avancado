using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Cliente
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public int Codigo { get; set; }
        public Contato Contato { get; set; }

        public Cliente(String nome, int idade, int codigo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Codigo = codigo;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return "Nome " + Nome + " Idade " + Idade + " Código " + Codigo + " Contato " + Contato.Telefone;
        }
    }
}
