using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    class ListaDeDados
    {
        List<Dado> montonDeDados;

        public ListaDeDados()
        {
            montonDeDados = new List<Dado>();
        }


        public List<Dado> GetListaDeDados()
        {
            return montonDeDados;
        }
    }
}
