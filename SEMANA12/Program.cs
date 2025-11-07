using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conti;
            Estudiantes e = new Estudiantes();
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
                Console.WriteLine("*** Menú de opciones ****");
                Console.WriteLine("* 1. Registrar          *");
                Console.WriteLine("* 2. Mostrar            *");
                Console.WriteLine("* 3. Eliminar           *");
                Console.WriteLine("* 4. Ordenar            *");
                Console.WriteLine("* 0. Salir              *");
                Console.WriteLine("*************************\n");

                int opc;

                while (true)
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) & opc >= 0 & opc <= 4)
                        break;
                    else Console.WriteLine("Ingrese una opción valida!\n");
                }

                switch (opc)
                {
                    case 0: return;
                    case 1: e.registrar(); break;
                    case 2: e.mostrar(); break;
                    case 3: e.eliminar(); break;
                    case 4: e.ordenarD(); break;
                }

                while (true)
                {
                    Console.Write("\n¿Desea continuar? (S/N): ");
                    conti = Console.ReadLine();
                    if (conti =="s" || conti =="n") break;
                    else Console.WriteLine("Ingrese solo 's' o 'n'!\n");
                }
            } while (conti == "s");

        }
    }
}
