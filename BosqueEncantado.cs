using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class BosqueEncantado:Mapa
    {
        public override void MostrarInteracciones()
        {
            Console.WriteLine("Interacción 1: Encuentras una poción mágica.");
            Console.WriteLine("Interacción 2: Encuentras una criatura misteriosa.");
        }

        public override void Interaccion1(Jugador jugador)
        {
            Console.WriteLine("Te adentras en el bosque encantado y encuentras una poción mágica.");
            jugador.Vida += 20;
        }

        public override void Interaccion2(Jugador jugador)
        {
            Console.WriteLine("Encuentras una criatura misteriosa en el bosque. ¿Qué haces?");
            Console.WriteLine("1. Tratas de comunicarte con la criatura");
            Console.WriteLine("2. La atacas");

            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    Console.WriteLine("La criatura te regala un amuleto que aumenta tu destreza.");
                    jugador.Destreza += 10;
                    break;
                case 2:
                    Console.WriteLine("La criatura es más fuerte de lo que pensabas. Pierdes vida.");
                    jugador.Vida -= 30;
                    break;
                default:
                    Console.WriteLine("Opción no válida. No haces nada.");
                    break;
            }
        }
    }
}
