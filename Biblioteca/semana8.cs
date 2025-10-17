using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class semana8
    {
        public void suma(int a, int b)
        {
            Console.WriteLine("\nSuma: "+(a+b));
        }

        public void resta(int a, int b)
        {
            Console.WriteLine("\nResta: " + (a - b));
        }

        public void multi(int a, int b)
        {
            Console.WriteLine("\nMultiplicación: " + (a * b));
        }

        public void divi(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("\nDivisión: " + (a / b));
            else
                Console.WriteLine("Error. No se puede dividir entre 0");
        }
    }
}
