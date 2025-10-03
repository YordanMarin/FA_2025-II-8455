using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secreto = rnd.Next(1,21);
            int intentos = 3;

            Console.WriteLine("****************************************************");
            Console.WriteLine("*       BIENVENIDOS AL JUEGO ADIVINADOR            *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("*  1. Ud. debe de adivinar el número entre 1 y 20  *");
            Console.WriteLine("*  2. Ud. tiene 3 intetentos                       *");
            Console.WriteLine("*  3. Por cada falla se le ortorgara una pista     *");
            Console.WriteLine("****************************************************");

            do
            {
                Console.Write("\nIngrese número: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero == secreto)
                {
                    Console.WriteLine("\nAdivinaste!");
                    return;
                }
                else
                {
                    intentos--;
                    if(numero < secreto)
                        Console.WriteLine($"Pista: El número es mayor. Le quedan {intentos} intentos");
                    else
                        Console.WriteLine($"Pista: El número es menor. Le quedan {intentos} intentos");
                }
            } while (intentos > 0);
            Console.WriteLine("\nNo lograste adivinar el número ", secreto);
        }
    }
}
