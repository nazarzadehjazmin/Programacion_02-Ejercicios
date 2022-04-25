using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo //si es internal solo es accesible dentro del mismo proyecto
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>(); //instancio la lista
        }

        public Equipo(short cantidad, string nombre)
            : this() // con : this() llamo al constructor privado y me aseguro que se instancie la lista cuando inicio el programa
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        //sobrecarga de operadores
        // el operador + agrega jugador al equipo siempre y cuando no exista en el equipo y no supere el limite establecido
        public static bool operator +(Equipo e, Jugador j)
        {

            if (e.jugadores.Count < e.cantidadJugadores) //menos que la cant de jugadores maxima
            {
                foreach (Jugador item in e.jugadores)
                {
                    //utilizo sobrecarga de == de la clase Jugador
                    if (item == j) 
                        //si el jugador del equipo es igual al jugador que me estan pasando
                        //compara por dni
                        return false;
                }
                e.jugadores.Add(j); //si no son =les los dni, lo agrega a la lista
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
