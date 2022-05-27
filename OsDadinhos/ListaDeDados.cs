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

        public void HideDados()
        {
            foreach (Dado dado in montonDeDados)
            {
                dado.GetImagen().Visible = false;
            }
        }

        public void ShowDados()
        {
            foreach (Dado dado in montonDeDados)
            {
                dado.GetImagen().Visible = true;
            }
        }

        public List<Dado> GetListaDeDados()
        {
            return montonDeDados;
        }
    }
}
