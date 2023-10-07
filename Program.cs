using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aventura de texto");

            Console.Write("Ingresa el nombre de tu jugador: ");
            string nombre = Console.ReadLine();

            int fuerza, destreza, vida;

            do
            {
                Console.WriteLine("Tu fuerza, destreza y vida juntas no pueden sumar más de 100 puntios");
                Console.Write("Asigna puntos de fuerza (max 100): ");
                fuerza = int.Parse(Console.ReadLine());

                Console.Write("Asigna puntos de destreza (max 100): ");
                destreza = int.Parse(Console.ReadLine());

                Console.Write("Asigna puntos de vida (max 100): ");
                vida = int.Parse(Console.ReadLine());

                if (fuerza + destreza + vida > 100)
                {
                    Console.WriteLine("La suma de fuerza, destreza y vida no debe ser mayor que 100. Inténtalo de nuevo.");
                }
            } while (fuerza + destreza + vida > 100);

            Jugador jugador = new Jugador(nombre, fuerza, destreza, vida);
        }
    }
}
