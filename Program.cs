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

            Console.WriteLine("\nComienza la aventura...");

            while (jugador.Vida > 0)
            {
                Console.WriteLine("\nElige una ubicación:");
                Console.WriteLine("1. Bosque Encantado");
                Console.WriteLine("2. Castillo Abandonado");
                Console.WriteLine("3. Cueva Oscura");

                int opcion = int.Parse(Console.ReadLine());

                Mapa ubicacion = null;

                switch (opcion)
                {
                    case 1:
                        ubicacion = new BosqueEncantado();
                        break;
                    case 2:
                        ubicacion = new CastilloAbandonado();
                        break;
                    case 3:
                        ubicacion = new CuevaOscura();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        continue;
                }

                Console.WriteLine($"\nTe encuentras en {ubicacion.GetType().Name}");
                Console.WriteLine("Interacciones disponibles:");
                ubicacion.MostrarInteracciones();

                int interaccion = int.Parse(Console.ReadLine());

                if (interaccion == 1)
                {
                    ubicacion.Interaccion1(jugador);
                }
                else if (interaccion == 2)
                {
                    ubicacion.Interaccion2(jugador);
                }
                else
                {
                    Console.WriteLine("Opción no válida. No haces nada.");
                }

                if (jugador.Fuerza >= 80)
                {
                    Console.WriteLine("\n¡Has encontrado el tesoro y ganado una gran fortuna! Has alcanzado un final especial. ¡Felicidades!");
                    break;
                }

                if (jugador.Vida <= 0)
                {
                    Console.WriteLine("\n¡Has perdido! Tu aventura ha llegado a su fin.");
                    break;
                }

                if (jugador.Fuerza >= 40 && jugador.Destreza >= 40)
                {
                    Console.WriteLine("\nHas logrado sobrevivir en esta ubicación. Tu aventura continúa.");
                }
            }

            Console.WriteLine("\nFin de la aventura. ¡Gracias por jugar!");
        }
    }
}
