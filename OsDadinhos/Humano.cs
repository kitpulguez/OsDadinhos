using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    public class Humano:Jugador
    {
        public Humano():this("", null)
        { }

        public Humano(string nombre, List<Dado> dadosPropios):base(nombre, dadosPropios)
        { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
