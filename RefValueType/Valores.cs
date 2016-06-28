using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueType
{
    public class Valores
    {
        public int X { get; set; }
        public int y { get; set; }


        public void Exemplo()
        {
            //passa o valor por referência para multiplicar
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public void Dobrar(Numeros num)
        {
            num.X *= 2;
            num.Y *= 2;
        }

        //recebe o valor por referência para multiplicar
        public void Dobrar(ref int valor)
        {
            valor *= 2;

        }
    }
}
