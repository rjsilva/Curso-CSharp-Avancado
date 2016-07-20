using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAssesores
{
    public class Conta
    {
        public String Cliente { get; set; }
        private Double saldo;

        public void depositar(double valor)
        {
            this.saldo = valor;
        }

        public void sacar(double valor)
        {
            this.saldo = saldo - valor;
        }

        public double consultar()
        {
            return this.saldo;
        }
    }
}
