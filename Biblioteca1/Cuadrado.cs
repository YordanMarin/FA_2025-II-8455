using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Cuadrado
    {
        public void area(int l)
        {
            Console.WriteLine("\nÁrea: " + (l * l));
        }

        public void perimetro(int l)
        {
            Console.WriteLine("\nPerímetro: " + (4 * l));
        }
    }
}
