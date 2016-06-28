using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesoresPropriedadesStrutsEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaStruts ps1 = new PessoaStruts();
            ps1.Nome = "ronaldo";
            ps1.Idade = 29;
            Funcao funcao = Funcao.Programador;

            PessoaStruts ps2 = new PessoaStruts();

            Console.WriteLine("STRUTS");
            ps2 = ps1; // VALUE TYPES, FAZ UMA CÓPIA 
            ps2.Nome = "DORA"; // SE FOSSE REFERÊNCIA TYPES MUDARIA O NOME DE PS1
            Console.WriteLine(ps2);
            Console.WriteLine(funcao);
            Console.WriteLine(ps1);

            Console.WriteLine("CLASS");
            Cliente c1 = new Cliente();
            Cliente c2 = c1; //APONTA PARA O MESMO ENDEREÇO DE MEMÓRIA, ISSO É REFERÊNCIA TYPES
            c1.Nome = "MARCÃO";
            c1.Idade = 49;

            c2.Nome = "Mônica"; // COMO É REFERÊNCIA TYPES MUDOU O NOME DE C1
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.ReadLine();
        }
    }
}
