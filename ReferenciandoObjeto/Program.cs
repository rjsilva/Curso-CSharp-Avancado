using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenciandoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cliente();
            c1.Nome = "Ronaldo José da Silva";
            c1.Idade = 29;

            var c2 = c1; //aponta para o mesmo endereço de memória
            c2.Nome = "Marcão Salustiano de Pontes";

            var c3 = new Cliente();
            c3.Nome = "Dora";
            c3.Idade = 40;
            Console.WriteLine(c3);
            Console.WriteLine(c2);
            Console.WriteLine(c1);
            Console.ReadLine();
        }
    }
}
