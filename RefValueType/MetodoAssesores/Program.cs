using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoAssesores
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Conta();
            c1.Cliente = "Ronaldo";
            c1.depositar(1000);
            var consulta = c1.consultar();
            Console.WriteLine("saldo " + consulta);
            c1.sacar(200);
            var consulta1 = c1.consultar();
            Console.WriteLine("saldo " + consulta1);
            Console.ReadLine();
        }
    }
}
