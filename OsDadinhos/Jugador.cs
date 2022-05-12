using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    abstract class Jugador
    {
        string nombre;
        int turnos, puntos;

        public Jugador() : this("")
        {

        }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            turnos = 0;
            puntos = 0;
        }

        public void TirarDados(List<Dado> listaDeDados)
        {
            foreach (Dado dado in listaDeDados)
            {
                if (!dado.GetRecogido())
                    dado.RandomNumber();
            }
        }

        public abstract void SeleccionarDado();

        public abstract void PuntuarYPasar();

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetTurnos(int turnos)
        {
            this.turnos = turnos;
        }

        public int GetTurnos()
        {
            return turnos;
        }

        public void SetPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public int GetPuntos()
        {
            return puntos;
        }


    }
}
