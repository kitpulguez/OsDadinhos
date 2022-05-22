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
        int numero, ejeXInicial, ejeYInicial;
        string name;        
        bool seleccionado, recogido, puntuando;
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
            puntuando = false;
            ejeXInicial = imagen.Location.X;
            ejeYInicial = imagen.Location.Y;
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

        public void SetPosicionInicial()
        {
            imagen.SetBounds(ejeXInicial, ejeYInicial, imagen.Size.Width, imagen.Size.Height);
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetEjeXInicial()
        {
            return ejeXInicial;
        }

        public void SetEjeXInicial(int ejeXInicial)
        {
            this.ejeXInicial = ejeXInicial;
        }

        public int GetEjeYInicial()
        {
            return ejeYInicial;
        }

        public void SetEjeYInicial(int ejeYInicial)
        {
            this.ejeYInicial = ejeYInicial;
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
