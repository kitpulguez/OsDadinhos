using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsDadinhos
{
    public class CPU:Jugador
    {
        int dadosRecogidos;
        Random r = new Random();

        public CPU() : this("", null)
        {
            dadosRecogidos = 0;
        }

        public CPU(string nombre, List<Dado> dadosPropios) : base(nombre, dadosPropios)
        {
            dadosRecogidos = 0;
        }

        public void SeleccionarDado(int numeros1, int numeros2, int numeros3, int numeros4, int numeros5, int numeros6)
        {
            SeleccionarDados1(numeros1);
            SeleccionarDados2(numeros2);
            SeleccionarDados3(numeros3);
            SeleccionarDados4(numeros4);
            SeleccionarDados5(numeros5);
            SeleccionarDados6(numeros6);
        }

        public void SeleccionarDados1(int numeros1)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 1 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public void SeleccionarDados2(int numeros2)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 2 && numeros2 >= 3 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public void SeleccionarDados3(int numeros3)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 3 && numeros3 >= 3 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public void SeleccionarDados4(int numeros4)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 4 && numeros4 >= 3 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public void SeleccionarDados5(int numeros5)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 5 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public void SeleccionarDados6(int numeros6)
        {
            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetNumero() == 6 && numeros6 >= 3 && !dado.GetRecogido())
                    dado.Seleccionar();
            }
        }

        public bool TirarOtraVez()
        {
            if (dadosRecogidos == 1)
            {
                if (r.Next(1, 1001) > 25)
                    return true;
            }
            else if (dadosRecogidos == 2)
            {
                if (r.Next(1, 1001) > 200)
                    return true;
            }
            else if (dadosRecogidos == 3)
            {
                if (r.Next(1, 1001) > 700)
                    return true;
            }
            else if (dadosRecogidos == 4)
            {
                if (r.Next(1, 1001) > 980)
                    return true;
            }
            else if (dadosRecogidos == 5)
            {
                if (r.Next(1, 1001) > 999)
                    return true;
            }

            return false;
        }

        public void RecogerDadosSeleccionados()
        {
            int counter = 0;

            foreach (Dado dado in GetListaDeDados())
            {
                if (dado.GetSeleccionado())
                {
                    dado.SetSeleccionado(false);
                    dado.GetImagen().BorderStyle = System.Windows.Forms.BorderStyle.None;
                    dado.Recoger();
                    dadosRecogidos++;
                }

                if (dado.GetRecogido())
                {
                    dado.GetImagen().SetBounds(1350 + counter, 200, dado.GetImagen().Size.Width, dado.GetImagen().Size.Height);
                    counter += 81;
                }
            }
        }

        public int GetDadosRecogidos()
        {
            return dadosRecogidos;
        }

        public void SetDadosRecogidos(int dadosRecogidos)
        {
            this.dadosRecogidos = dadosRecogidos;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
