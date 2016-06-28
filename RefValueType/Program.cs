using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores vl = new Valores();
            //vl.Exemplo();
            Numeros num = new Numeros();
            num.X = 10;
            num.Y = 20;

            //Passa um obejto para multiplicar os números
            vl.Dobrar(num);
            Console.WriteLine(num.X);
            Console.WriteLine(num.Y);
            Console.ReadLine();
        }
    }
}
