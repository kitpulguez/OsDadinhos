using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    class Humano:Jugador
    {
        public Humano():this("")
        { }

        public Humano(string nombre):base(nombre)
        { }

        public override void SeleccionarDado()
        {

        }

        public override void PuntuarYPasar()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
