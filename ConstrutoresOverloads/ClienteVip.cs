using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresOverloads
{
    class ClienteVip : Cliente
    {
        public String Descricao { get; set; }

        public override string ToString()
        {
            return "Descrição: " + Descricao + " Nome: " + Nome + " Código: " + Codigo.ToString() + "\n" + "Email: " + contato.Email + " Telefone: " + contato.Telefone;
        }

        public ClienteVip(String nome, int codigo, String descricao)
            : base(nome, codigo)
        {
            this.Descricao = descricao;
            this.contato = new Contato();
        }

        public ClienteVip()
        {

        }
    }
}
