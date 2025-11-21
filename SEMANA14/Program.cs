using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;

            while (true)
            {
                Console.Write("Ingrese nombre 1: ");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }
            while (true)
            {
                Console.Write("Ingrese nombre 2: ");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("cantidad de caracteres de nombre1: " + nom1.Length);
            Console.WriteLine("cantidad de caracteres de nombre2: " + nom2.Length);
            Console.WriteLine("Nombre 1 en mayusculas: "+nom1.ToUpper());
            Console.WriteLine("Nombre 2 en minusculas: "+nom2.ToLower());
            if (nom1.CompareTo(nom2) == 0) Console.WriteLine("Nombres son iguales");
            else Console.WriteLine("Nombres Son diferentes");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (nom1.Contains("an")) Console.WriteLine("Si contiene 'an'");
            else Console.WriteLine("No contiene 'an'");
            if (nom1.IndexOf("a") != -1)
                Console.WriteLine("1° Posición: " + nom1.IndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            if (nom2.LastIndexOf("a") != -1)
                Console.WriteLine("ultima Posición: " + nom2.LastIndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            Console.WriteLine("Insertando UPN"+nom1.Insert(0,"UPN"));
            Console.WriteLine("Insertando SISTEMAS" + nom2.Insert(nom2.Length,"SISTEMAS"));
            if (nom1.Length > 5)
                Console.WriteLine("eliminando desde 5 pos: " + nom1.Remove(5));
            else Console.WriteLine("No hay al menos 5 caracteres");
            if (nom1.Contains("a")) 
                Console.WriteLine("Reemplazando a por @: "+nom1.Replace("a","@"));
            else Console.WriteLine("No contiene 'a'");
            Console.ResetColor();
            if (nom1.Contains("a"))
            {
                Console.Write("La división de partes es: ");
                string[] partes = nom1.Split('a');
                for(int i = 0;i<partes.Length;i++)
                    Console.Write(partes[i]+" -> ");
            }
            else Console.WriteLine("No contiene 'a'");

            Console.BackgroundColor = ConsoleColor.Green;
            if (nom1.Length > 4)
                Console.WriteLine("\nSub cadena: " + nom1.Substring(4));
            else Console.WriteLine("\nNo hay almenos 4 caracteres");
            Console.ResetColor ();

            char[] nom = nom1.ToCharArray();
            for(int i = 0; i < nom.Length; i++)
                Console.WriteLine(nom[i]);
            
            Console.Write("En reversa: ");
            for (int i = nom.Length-1; i >=0 ; i--)
                Console.Write(nom[i]);
            
            Console.Write("\nOrdenado: ");
            Array.Sort(nom);
            for (int i = 0; i < nom.Length; i++)
                Console.Write(nom[i]);

        }
    }
}
