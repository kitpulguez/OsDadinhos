using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    class CPU:Jugador
    {
        public CPU() : this("")
        { }

        public CPU(string nombre) : base(nombre)
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
