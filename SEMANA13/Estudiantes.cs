using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Estudiantes
    {
        string[] nombres = new string[0];
        byte[] edades = new byte[0];
        int pos = 0;

        public void insertar()
        {
            string seguir;
            do
            {
                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edades, edades.Length + 1);
                Console.Write("\nIngrese nombre: ");
                nombres[pos] = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                edades[pos] = byte.Parse(Console.ReadLine());
                pos++;

                while (true)
                {
                    Console.Write("\nPara seguier registrando (s/n): ");
                    seguir = Console.ReadLine();
                    if (seguir == "s" || seguir == "n") break;
                    else Console.WriteLine("Opción incorrecta\n");
                }
            } while (seguir == "s");
            
        }

        public void mostrar()
        {
            Console.WriteLine("\nPOS\tNOMBRE\t\tEDAD");
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i}\t{nombres[i]}\t\t{edades[i]}");
            }
        }

        public int buscar(string nom)
        {
            int indice = -1;
            for(int i = 0;i < nombres.Length; i++)
            {
                if (nom == nombres[i])
                    indice = i;
            }
            return indice;
        }

        public void modificar()
        {
            Console.Write("\nIngrese el nombre a modificar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                Console.Write("\nIngrese el nuevo nombre: ");
                nombres[indice] = Console.ReadLine();
                Console.Write("Ingrese la nueva edad: ");
                edades[indice] = byte.Parse(Console.ReadLine());
            }
            else Console.WriteLine("\nNo existe");
        }

        public void eliminar()
        {
            Console.Write("\nIngrese el nombre a eliminar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                for(int i = indice;i<nombres.Length-1 ; i++)
                {
                    nombres[i] = nombres[i + 1];
                    edades[i] = edades[i+1];
                }
                Array.Resize(ref nombres, nombres.Length-1);
                Array.Resize(ref edades, edades.Length-1);
                pos--;
            }
            else Console.WriteLine("\nNo existe");
        }

        public void ordenar()
        {
            for( int i = 0;  i < nombres.Length-1; i++)
            {
                for (int j = 0; j < nombres.Length-1-i; j++)
                {
                    if (string.Compare(nombres[i], nombres[i+1]) > 0)
                    {
                        string temp = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i+1] = temp;

                        byte temp2 = edades[i];
                        edades[i] = edades[i + 1];
                        edades[i + 1] = temp2;
                    }
                }
            }
        }
    }
}
