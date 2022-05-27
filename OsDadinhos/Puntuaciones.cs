using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    public class Puntuaciones:IComparable<Puntuaciones>
    {
        string nombre;
        int turnos, puntos;
        DateTime fechaVictoria;

        public Puntuaciones():this("", 0, 0, DateTime.Now)
        { }

        public Puntuaciones(string nombre, int puntos, int turnos)
        {
            this.nombre = nombre;
            this.turnos = turnos;
            this.puntos = puntos;
            fechaVictoria = DateTime.Now;
        }

        public Puntuaciones(string nombre, int puntos, int turnos, DateTime fechaVictoria)
        {
            this.nombre = nombre;
            this.turnos = turnos;
            this.puntos = puntos;
            this.fechaVictoria = fechaVictoria;
        }

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

        public void SetFechaVictoria(DateTime fechaVictoria)
        {
            this.fechaVictoria = fechaVictoria;
        }

        public DateTime GetFechaVictoria()
        {
            return fechaVictoria;
        }

        public override string ToString()
        {
            return $"{nombre}          {puntos}          {turnos}          {fechaVictoria}";
        }

        public int CompareTo(Puntuaciones p)
        {
            if (p.puntos == this.puntos)
                return this.turnos.CompareTo(p.turnos);

            return p.puntos.CompareTo(this.puntos);
        }
    }
}
