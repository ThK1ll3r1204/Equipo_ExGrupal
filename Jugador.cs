using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class Jugador
    {        
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Vida { get; set; }

        public Jugador(string nombre, int fuerza, int destreza, int vida)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Destreza = destreza;
            Vida = vida;
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fuerza: {Fuerza}");
            Console.WriteLine($"Destreza: {Destreza}");
            Console.WriteLine($"Vida: {Vida}");
        }
    }
}
