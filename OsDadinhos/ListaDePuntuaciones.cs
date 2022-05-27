using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    public class ListaDePuntuaciones
    {
        public List<Puntuaciones> puntuaciones;

        public ListaDePuntuaciones()
        {
            puntuaciones = new List<Puntuaciones>();
        }

        public List<Puntuaciones> GetListaPuntuaciones()
        {
            return puntuaciones;
        }
    }    
}
