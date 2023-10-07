using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class Game
    {
        
        Mapa ubicacion = null;
        Mapa mapa = new Mapa();

        public void Start()
        {
            Console.WriteLine("Bienvenido a la aventura de texto");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.Write("Ingresa el nombre de tu personaje: ");
            string nombre = Console.ReadLine();

            int fuerza, destreza, vida;

            do
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Tu fuerza, destreza y vida juntas no pueden sumar más de 100 puntos y deben haber un minimo de 10 puntos en cada estadistica.");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.Write("Asigna puntos de fuerza (min. 10, max. 80): ");
                fuerza = int.Parse(Console.ReadLine());

                Console.Write("Asigna puntos de destreza (min. 10, max. 80): ");
                destreza = int.Parse(Console.ReadLine());

                Console.Write("Asigna puntos de vida (mi.n 10, max. 80): ");
                vida = int.Parse(Console.ReadLine());

                if (fuerza + destreza + vida > 100 || fuerza < 10 || destreza < 10 || vida < 10)
                {
                    Console.WriteLine("La suma de estadisticas no debe ser mayor que 100 y cada una debe tener un minimo de 10 puntos. Inténtalo de nuevo.");
                    Console.WriteLine("----------------------------------------------------------------");
                }
            } while (fuerza + destreza + vida > 100 || fuerza < 10 || destreza < 10 || vida < 10);

            Jugador jugador = new Jugador(nombre, fuerza, destreza, vida);

            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("\nComienza la aventura...");
            Console.WriteLine("------------------------------------------------------------------------");

            while (jugador.Vida > 0 && jugador.EndingCheck == false)
            {
                Console.WriteLine("\nElige una ubicación:");
                Console.WriteLine("1. Bosque Encantado");
                Console.WriteLine("2. Castillo Abandonado");
                Console.WriteLine("3. Cueva Oscura");
                Console.WriteLine("4. Ver a tu personaje");

                int opcion = int.Parse(Console.ReadLine());


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
                    case 4:
                        jugador.MostrarEstado();
                        continue;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        continue;
                }

                Console.WriteLine("------------------------------------------------------------------------");
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

                if (jugador.Vida <= 0 && jugador.EndingCheck)
                {
                    Console.WriteLine("\n¡Has perdido! Tu aventura ha llegado a su fin.");
                    break;
                }

                if (jugador.Fuerza >= 40 && jugador.Destreza >= 40)
                {
                    Console.WriteLine("\nHas logrado sobrevivir en esta ubicación. Tu aventura continúa.");
                }
            }

            
            //Condicion que muestra los finales especiales
            if (jugador.EndingCheck == true)
            {
                ubicacion.MostrarFinalDelJuego(jugador);
            }

            Console.WriteLine("\nFin de la aventura. ¡Gracias por jugar!");
            Console.ReadLine();
        }

      


      
    }
}
