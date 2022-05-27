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
        TablaPuntuaciones ventanaRanking;

        public MenuInicio()
        {
            InitializeComponent();
            ventanaComoJugar = new ComoJugar();
            ventanaSeleccionarNombre = new SeleccionarNombre();
            ventanaRanking = new TablaPuntuaciones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtUnJugador(object sender, EventArgs e)
        {
            this.Hide();
            ventanaSeleccionarNombre.ShowDialog();
            this.Close();                     
        }

        private void BtComoJugar(object sender, EventArgs e)
        {
            ventanaComoJugar.ShowDialog();
        }

        private void BtSalir(object sender, EventArgs e)
        {
            Close();
        }

        private void BtRanking_Click(object sender, EventArgs e)
        {
            ventanaRanking.ShowDialog();
        }
    }
}
