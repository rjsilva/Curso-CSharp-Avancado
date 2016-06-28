using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cliente();
            c1.Nome = "ronaldo";
            c1.Codigo = 423543;
            c1.contato.Email = "ronaldo@gmail.com";
            c1.contato.Telefone = "11-9876-0987";
            Console.WriteLine(c1);

            Console.WriteLine("CLIENTE VIP");
            var cVip = new ClienteVip();
            cVip.Nome = "Marcão";
            cVip.Codigo = 101010;
            cVip.contato.Email = "Marcao@gmail.com";
            cVip.contato.Telefone = "11-987654-0987";
            cVip.Descricao = "Master";
            Console.WriteLine(cVip);

            Console.WriteLine("COM OVERLOAD DE CONSTRUTORE");
            Cliente cVp2 = new ClienteVip("Dora",1111,"Simples");
            Console.WriteLine(cVp2);
            Console.ReadLine();

        }
    }
}
