using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class Mapa
    {
        public virtual void MostrarInteracciones()
        {
            Console.WriteLine("Interacción 1");
            Console.WriteLine("Interacción 2");
        }

        public virtual void Interaccion1(Jugador jugador)
        {
            Console.WriteLine("Interacción 1 en la ubicación base.");
        }

        public virtual void Interaccion2(Jugador jugador)
        {
            Console.WriteLine("Interacción 2 en la ubicación base.");
        }

        //Metodo que muestra el final del juego, en los 3 escenarios es donde se edita el final
        public virtual void MostrarFinalDelJuego(Jugador jugador)
        {
            Console.WriteLine("Mostrar final del juego del area en cuestion");

        }
    }
}
