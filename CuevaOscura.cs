using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal_AventuraDeTexto
{
    class CuevaOscura : Mapa
    {
        
        public override void MostrarInteracciones()
        {
            Console.WriteLine("Interacción 1: Encuentras una espada mágica.");
            Console.WriteLine("Interacción 2: Encuentras una araña gigante.");
        }

        public override void Interaccion1(Jugador jugador)
        {
            Console.WriteLine("En la oscura cueva, encuentras una espada mágica.");
            jugador.Fuerza += 25;
        }

        public override void Interaccion2(Jugador jugador)
        {
            Console.WriteLine("Dentro de la cueva, te encuentras con una araña gigante. ¿Cómo reaccionas?");
            Console.WriteLine("1. Luchas contra la araña");
            Console.WriteLine("2. Tratas de negociar con la araña");

            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    Console.WriteLine("Derrotas a la araña y obtienes un valioso objeto.");
                    jugador.Destreza += 15;
                    break;
                case 2:
                    Console.WriteLine("La araña no acepta tu oferta y te ataca. Sus colmillos perforan tu brazo inyectando un poderoso veneno.");
                    //Aqui esta la condicion para que se active el final
                    jugador.EndingCheck = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. No haces nada.");
                    break;
            }
        }

        //Final del escenario de cueva ya terminado
        public override void MostrarFinalDelJuego(Jugador jugador)
        {
            Console.WriteLine("El veneno de la araña acaba con tus fuerzas, caes en seco al suelo, ves la luz al final de la cueva oscureciendose mientras sientes como eres arrastrado por ocho horripilantes patas. Tu historia acaba aqui, convertido en comida de araña.");
            
        }
    }
}
