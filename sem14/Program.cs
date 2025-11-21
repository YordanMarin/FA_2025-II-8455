using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Ingrese un decimal: ");
            string deci = Console.ReadLine().Trim();

            if (deci.Contains("."))
            {
                string[] x = deci.Split('.');

                if (x[0].Length == 1 && x[1].Length == 2)
                {
                    num = double.Parse(deci);
                    Console.WriteLine("Decimal: " + num);
                }
                else Console.WriteLine("Solo se permiten 1 entero y 2 decimales");
            }
            else Console.WriteLine("Solo se permiten decimaleds");
        }
    }
}
