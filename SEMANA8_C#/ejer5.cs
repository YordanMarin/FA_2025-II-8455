using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace SEMANA8_C_
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            semana8 s = new semana8(); //instancia
            int opc;
            string conti;
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE CALCULADORA BÁSICA\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("0. Salir\n");

                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc = int.Parse(Console.ReadLine());
                    if (opc < 0 | opc > 4)
                        Console.WriteLine("Error. Opción no valida. Vuelve a ingresar\n");
                } while (opc < 0 | opc > 4);

                Console.Write("\nIngrese el primer número: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int b = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: s.suma(a,b); break;
                    case 2: s.resta(a, b); break;
                    case 3: s.multi(a,b); break;
                    case 4: s.divi(a, b); break;
                }

                Console.Write("\n¿Desea continuar? (y): ");
                conti = Console.ReadLine();
            } while (conti == "y");
        }
    }
}
