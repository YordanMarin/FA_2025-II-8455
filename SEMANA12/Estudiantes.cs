using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA12
{
    internal class Estudiantes
    {
        byte[] edades = new byte[0];
        int pos = 0;
        public void registrar()
        {
            byte ed;
            while (true)
            {
                Console.Write("\nIngrese una edad: ");
                if (byte.TryParse(Console.ReadLine(), out ed) & ed >= 14 & ed <= 120)
                    break;
                else Console.WriteLine("Ingrese una edad valida!\n");
            }

            Array.Resize(ref edades, edades.Length+1);
            edades[pos] = ed;
            pos++;
            Console.WriteLine("\nEdad registrado correctamente!");
        }

        public void mostrar()
        {
            Console.Write("\nPOS\tEDAD\n");
            for(int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine($"{i}\t{edades[i]}");
            }
        }

        public void eliminar()
        {
            Console.Write("\nIngrese la edad a eliminar: ");
            byte eli = byte.Parse(Console.ReadLine());

            int indice = -1;

            for(int i = 0;i < edades.Length; i++)
            {
                if (edades[i] == eli)
                    indice = i;
            }

            if (indice != -1)
            {
                for (int i = 0; i < edades.Length-1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                pos--;
                Console.WriteLine("\nEdad eliminado correctamente.");
            }
            else Console.WriteLine("\nNo existe no se puede eliminar");
        }

        public void ordenarD()
        {
            for(int i = 0;i < edades.Length-1; i++)
            {
                for(int j = 0; j < edades.Length-i-1; j++)
                {
                    if (edades[j] < edades[j + 1])
                    {
                        byte temp = edades[j];
                        edades[j] = edades[j+1];
                        edades[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSe ordeno correctamente.");
        }
    }
}
