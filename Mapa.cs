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
    }
}
