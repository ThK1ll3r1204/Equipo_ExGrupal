using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AventuraPropia
{
    class CastilloAbandonado:Mapa
    {
        public override void MostrarInteracciones()
        {
            Console.WriteLine("Interacción 1: Encuentras un cofre del tesoro.");
            Console.WriteLine("Interacción 2: Encuentras un fantasma.");
        }

        public override void Interaccion1(Jugador jugador)
        {
            Console.WriteLine("Exploras el castillo abandonado y encuentras un cofre del tesoro.");
            jugador.Fuerza += 15;
        }

        public override void Interaccion2(Jugador jugador)
        {
            Console.WriteLine("Dentro del castillo, te encuentras con un fantasma. ¿Qué decides hacer?");
            Console.WriteLine("1. Intentas comunicarte con el fantasma");
            Console.WriteLine("2. Sales corriendo del castillo");

            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    Console.WriteLine("El fantasma te revela un secreto que aumenta tu fuerza.");
                    jugador.Fuerza += 20;
                    break;
                case 2:
                    Console.WriteLine("Escapas del castillo asustado.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. No haces nada.");
                    break;
            }
        }
    }
}
