using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsDadinhos
{
    public partial class MenuInicio : Form
    {
        ComoJugar ventanaComoJugar;
        SeleccionarNombre ventanaSeleccionarNombre;

        public MenuInicio()
        {
            InitializeComponent();
            ventanaComoJugar = new ComoJugar();
            ventanaSeleccionarNombre = new SeleccionarNombre();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtUnJugador(object sender, EventArgs e)
        {
            ventanaSeleccionarNombre.ShowDialog();
        }

        private void BtComoJugar(object sender, EventArgs e)
        {
            ventanaComoJugar.ShowDialog();
        }

        private void BtSalir(object sender, EventArgs e)
        {
            Close();
        }
    }
}
