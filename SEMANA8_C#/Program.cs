using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = suma4();
            Console.WriteLine("\nSuma: "+suma);
        }

        static int suma4()
        {
            Console.Write("Ingrese el primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int y = int.Parse(Console.ReadLine());

            return x + y;
        }
        static void suma3()
        {
            Console.Write("Ingrese el primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (x, y));
        }
        static void suma1(int a, int b)
        {
            Console.WriteLine("\nSuma: " + (a + b));
        }

        static int suma2(int a, int b)
        {
            int resul = a + b;
            return resul;
        }
    }
}
