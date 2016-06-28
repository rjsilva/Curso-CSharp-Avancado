using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresOverloads
{
    public class Cliente
    {
        public String Nome { get; set; }
        public int Codigo { get; set; }
        public Contato contato { get; set; }

        public Cliente()
        {
            this.contato = new Contato();
        }

        public Cliente(String nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Código: " + Codigo.ToString() + "\n" + "Email: " + contato.Email + " Telefone: " + contato.Telefone;
        }
    }
}
