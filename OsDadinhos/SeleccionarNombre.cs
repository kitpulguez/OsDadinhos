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
    public partial class SeleccionarNombre : Form
    {
        Partida ventanaPartida;

        public SeleccionarNombre()
        {
            InitializeComponent();
            ventanaPartida = new Partida();
        }

        private void BtConfirmarNombreJugador_Click(object sender, EventArgs e)
        {
            ventanaPartida.lbPlayerNombreAclarador.Text = GetNombre();
            ventanaPartida.ShowDialog();
            Close();
        }

        public string GetNombre()
        {
            return tbElegirNombreJugador.Text;
        }
    }
}
