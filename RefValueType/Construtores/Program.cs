using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Cliente("ronaldo", 29, 9999);
            c1.Contato.Telefone = "909090909";

            var cVip = new ClienteVip("Jose", 29, 3333);
            cVip.Tipo = "Master";
            Console.WriteLine(cVip);
            Console.WriteLine();
            Console.WriteLine(c1);
            Console.ReadLine();
        }

    }
}
