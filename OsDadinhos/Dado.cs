using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsDadinhos
{
    public class Dado
    {
        Random r = new Random();
        int numero;
        string name;        
        bool seleccionado, recogido;
        PictureBox imagen = new PictureBox();

        public Dado():this("", null)
        {  }

        public Dado(string name, PictureBox imagen)
        {
            this.name = name;
            this.imagen = imagen;
            this.seleccionado = false;
            this.recogido = false;
            numero = r.Next(1, 7);
        }

        public void RandomNumber()
        {
            numero = r.Next(1, 7);
        }

        public void Seleccionar()
        {
            if (seleccionado)
            {
                seleccionado = false;
                imagen.BorderStyle = BorderStyle.None;
            }
            else
            {
                seleccionado = true;
                imagen.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public void Recoger()
        {
            if (recogido)
                recogido = false;
            else
                recogido = true;
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public bool GetSeleccionado()
        {
            return seleccionado;
        }

        public void SetSeleccionado(bool seleccionado)
        {
            this.seleccionado = seleccionado;
        }

        public bool GetRecogido()
        {
            return recogido;
        }

        public void SetRecogido(bool recogido)
        {
            this.recogido = recogido;
        }

        public PictureBox GetImagen()
        {
            return imagen;
        }

        public void SetImagen(PictureBox imagen)
        {
            this.imagen = imagen;
        }

    }
}
